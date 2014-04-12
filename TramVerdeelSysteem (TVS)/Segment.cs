using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TramVerdeelSysteem__TVS_
{
    public class Segment
    {

        private int _spoorId;
        private Spoor _spoor;

        private Segment(int id, bool geblokkeerd, int nummer, string special)
        {
            Id = id;
            Geblokkeerd = geblokkeerd;
            Nummer = nummer;
            Special = special;
        }

        public int Id { get; private set; }
        public int Nummer { get; set; }
        public bool Geblokkeerd { get; set; }
        public int Spoornummer { get; private set; }

        public Spoor Spoor
        {
            get
            {
                if (_spoor == null)
                {
                    _spoor = TramVerdeelSysteem__TVS_.Spoor.GetById(_spoorId);
                }
                return _spoor;
            }
        }

        public Tram Tram
        {
            get
            {
                Database db = new Database();

                TramVerdeelSysteem__TVS_.Tram tram = null;

                try
                {
                    db.CreateCommand("SELECT id FROM tram WHERE segment_id = :id");
                    db.AddParameter("id", Id);
                    if (db.Read())
                    {
                        tram = TramVerdeelSysteem__TVS_.Tram.GetById(db.GetValueByColumn<int>("id"));
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

        public void ChangeStatus(bool geblokkeerd)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE segment SET spoorstatus = :status WHERE id = :id");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("id", Id);
                db.Open();
                db.Execute();
                db.Close();

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

        public void ChangeTram(Tram tram)
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("UPDATE tram SET segment_id = 0 WHERE segment_id = :segmentid");
                db.AddParameter("segmentid", Id);
                db.Open();
                db.Execute();

                if (tram != null)
                {
                    db.Close();
                    db.CreateCommand("UPDATE tram SET segment_id = :segmentid WHERE id = :tramid");
                    db.AddParameter("segmentid", Id);
                    db.AddParameter("id", tram.Id);
                    db.Open();
                    db.Execute();
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
                    bool geblokkeerd = db.GetValueByColumn<string>("spoorstatus") == "geblokkeerd";

                    segment = new Segment(db.GetValueByColumn<int>("id"), geblokkeerd, db.GetValueByColumn<int>("nummer"), db.GetValueByColumn<string>("special"));
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

        public static Segment GetBySegmentnummerAndSpoornummer(int segmentnummer, int spoornummer)
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

                    segment = new Segment(db.GetValueByColumn<int>("id"), geblokkeerd, db.GetValueByColumn<int>("nummer"), db.GetValueByColumn<string>("special"));
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
                    segments.Add(GetBySegmentnummerAndSpoornummer(db.GetValueByColumn<int>("nummer"), nummer));
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
