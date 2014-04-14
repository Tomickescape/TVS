using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TVS
{
    public class Segment
    {

        private int _spoorId;

        private Segment(int id, bool geblokkeerd, int nummer, string special, int spoorId)
        {
            _spoorId = spoorId;
            Id = id;
            Geblokkeerd = geblokkeerd;
            Nummer = nummer;
            Special = special;
        }

        public int Id { get; private set; }
        public int Nummer { get; set; }
        public bool Geblokkeerd { get; set; }

        public Spoor Spoor
        {
            get
            {
                return Spoor.GetById(_spoorId);
            }
        }

        public Tram Tram
        {
            get
            {
                Database db = new Database();

                Tram tram = null;

                try
                {
                    db.CreateCommand("SELECT id FROM tram WHERE segment_id = :id");
                    db.AddParameter("id", Id);
                    if (db.Read())
                    {
                        tram = Tram.GetById(db.GetValueByColumn<int>("id"));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    db.Close();
                }

                return tram;
            }
        }

        public string Special { get; private set; }

        public bool CheckUitrij()
        {
            return CheckUitrij(null);
        }

        public bool CheckUitrij(Tram parTram)
        {
            if (Special == "uitrijding")
            {
                int nummer = Spoor.Nummer;
                List<Spoor> sporen = new List<Spoor>();

                Spoor spoor1 = TVS.Spoor.GetBySpoornummer(nummer - 1);
                Spoor spoor2 = TVS.Spoor.GetBySpoornummer(nummer + 1);

                if (spoor1 != null)
                {
                    sporen.Add(spoor1);
                }
                if (spoor2 != null)
                {
                    sporen.Add(spoor2);
                }

                foreach (Spoor spoor in sporen)
                {
                    if (spoor != null)
                    {
                        Segment segment = spoor.Segments.Find(x => x.Nummer == Nummer);

                        if (segment != null)
                        {
                            Tram tram = segment.Tram;
                            if (tram == null)
                            {
                                return false;
                            }
                            else if (parTram != null && parTram.Nummer == tram.Nummer)
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }

        public void ChangeGeblokkeerd(bool geblokkeerd)
        {

            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE segment SET status = :status WHERE id = :id");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("id", Id);
                db.Execute();


                if (Tram != null)
                {
                    ChangeTram(null);
                }

                Geblokkeerd = geblokkeerd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
        }

        public void ChangeGeblokkeerdAndLowerNummers(bool geblokkeerd)
        {

            Database db = new Database();
            try
            {                
                db.CreateCommand("UPDATE segment SET status = :status WHERE spoor_id = :spoorId AND nummer " + (geblokkeerd ? "<" : ">") + "= :nummer");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("spoorId", Spoor.Id);
                db.AddParameter("nummer", Nummer);
                db.Execute();

                if (geblokkeerd)
                {
                    Spoor spoor = Spoor;
                    foreach (Segment segment in Spoor.Segments)
                    {
                        if (segment.Nummer < Nummer)
                        {
                            segment.ChangeTram(null);
                        }
                    }
                }

                if (Tram != null)
                {
                    ChangeTram(null);
                }

                Geblokkeerd = geblokkeerd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
        }

        public void ToggleGeblokkeerd()
        {
            ChangeGeblokkeerdAndLowerNummers(!Geblokkeerd);
        }

        public void ChangeTram(Tram tram)
        {
            Database db = new Database();

            try
            {
                if (Tram != null)
                {
                    Tram.ChangeSegment(null);
                }

                if (tram != null)
                {
                    tram.ChangeSegment(this);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
        }

        public static Segment GetById(int id)
        {
            Segment segment = null;

            Database db = new Database();

            try
            {
                db.CreateCommand(
                    "SELECT * FROM segment WHERE id = :id");
                db.AddParameter("id", id);
                if (db.Read())
                {
                    bool geblokkeerd = db.GetValueByColumn<string>("status") == "geblokkeerd";

                    segment = new Segment(db.GetValueByColumn<int>("id"), geblokkeerd, db.GetValueByColumn<int>("nummer"), db.GetValueByColumn<string>("special"), db.GetValueByColumn<int>("spoor_id"));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
            return segment;
        }

        public static Segment GetBySpoornummerAndSegmentnummer(int spoornummer, int segmentnummer)
        {
            Segment segment = null;
            
            Database db = new Database();

            try
            {
                db.CreateCommand(
                    "SELECT segment.* FROM segment " +
                    "LEFT JOIN spoor ON spoor.id = segment.spoor_id " +
                    "WHERE spoor.nummer = :spoornummer and segment.nummer = :segmentnummer");
                db.AddParameter("spoornummer", spoornummer);
                db.AddParameter("segmentnummer", segmentnummer);

                if (db.Read())
                {
                    bool geblokkeerd = db.GetValueByColumn<string>("status") == "geblokkeerd";

                    segment = new Segment(db.GetValueByColumn<int>("id"), geblokkeerd, db.GetValueByColumn<int>("nummer"), db.GetValueByColumn<string>("special"), db.GetValueByColumn<int>("spoor_id"));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }
            return segment;
        }

        public static List<Segment> GetBySpoornummer(int nummer)
        {
            List<Segment> segments = new List<Segment>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT segment.* FROM segment JOIN spoor ON spoor.id = segment.spoor_id WHERE spoor.nummer = :nummer");
                db.AddParameter("nummer", nummer);
                while(db.Read())
                {
                    segments.Add(GetBySpoornummerAndSegmentnummer(nummer, db.GetValueByColumn<int>("nummer")));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.Close();
            }

            return segments;
        }
        
    }
}
