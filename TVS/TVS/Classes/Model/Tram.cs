using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TVS
{
    public class Tram
    {

        private int _segmentId;
        private Segment _segment;
        private bool _isSegmentLoaded = false;

        private int _remiseId;

        private List<int> _lijnen = new List<int>(); 


        private Tram(int id, string type, int nummer, Status status, string rfidCode, int remiseId, int segmentId)
        {
            _segmentId = segmentId;
            _remiseId = remiseId;

            Id = id;
            Type = type;
            Nummer = nummer;
            Status = status;
            RfidCode = rfidCode;

            switch (type) // wat doet dit?
            {
                case "11g":
                    _lijnen.Add(5);
                    break;
                case "12g":
                    _lijnen.Add(16);
                    _lijnen.Add(24);
                    break;
            }
        }

        public int Id { get; private set; }
        public string Type { get; private set; }
        public int Nummer { get; private set; }
        public Status Status { get; private set; }
        public string RfidCode { get; private set; }
        public List<int> Lijnen { get { return new List<int>(_lijnen);} }

        public Remise Remise
        {
            get
            {
                return Remise.GetById(_remiseId);
            }
        }

        public void ChangeStatus(Status status)
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("UPDATE tram SET status = :status WHERE id = :id");
                db.AddParameter("status", status.ToString());
                db.AddParameter("id", Id);
                db.Execute();

                Status = status;
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

        public Segment Segment
        {
            get
            {
                if (!_isSegmentLoaded)
                {
                    _segment = Segment.GetById(_segmentId);
                    _isSegmentLoaded = true;
                }
                return _segment;
            }
        }

        // haal een tram op aan de hand van het ID nummer
        public static Tram GetById(int parId)
        {
            Tram tram = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM tram WHERE id = :id");
                db.AddParameter("id", parId);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;

                while (dr.Read())
                {
                    Status status;
                    string StringStatus = dr.GetValueByColumn<string>("status");

                    if (StringStatus == "Defect")
                    {
                        status = Status.Defect;
                    }
                    else if (StringStatus == "Onderhoud")
                    {
                        status = Status.Onderhoud;
                    }
                    else
                    {
                        status = Status.Gereed;
                    }
                    int id = (dr.GetValueByColumn<int>("id"));
                    string type = (dr.GetValueByColumn<string>("type"));
                    int nummer = (dr.GetValueByColumn<int>("nummer"));
                    string rfidcode = (dr.GetValueByColumn<string>("rfidcode"));
                    int remiseId = (dr.GetValueByColumn<int>("remise_id"));
                    int segmentId = (dr.GetValueByColumn<int>("segment_id"));
                    tram = new Tram(id, type, nummer, status, rfidcode, remiseId, segmentId);

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

        public void ChangeSegment(Segment segment)
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("UPDATE tram SET segment_id = :segmentId WHERE id = :id");
                db.AddParameter("segmentId", segment != null ? segment.Id : 0);
                db.AddParameter("id", Id);
                db.Open();
                db.Execute();
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

        public void Delete()
        {
            Database db = new Database();

            try
            {
                db.CreateCommand("DELETE FROM tram WHERE id = :id");
                db.AddParameter("id", Id);
                db.Execute();
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

        public static void Insert(string type, int nummer, Status status, string rfid)
        {
            Database db = new Database();

            try
            {
                if (Tram.GetByNummer(nummer) != null)
                {
                    throw new Exception("Tram met dit nummer bestaat al.");
                }

                db.CreateCommand("INSERT INTO tram(type, nummer, status, rfidcode) VALUES (:type, :nummer, :status, :rfid)");
                db.AddParameter("type", type);
                db.AddParameter("nummer", nummer);
                db.AddParameter("status", status.ToString());
                db.AddParameter("rfid", rfid);
                db.Execute();
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

        public static Tram GetByNummer(int parNummer)
        {
            Tram tram = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT id FROM tram WHERE nummer = :nummer");
                db.AddParameter("nummer", parNummer);

                while (db.Read())
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

        public static Tram GetByRfid(string rfid)
        {
            Tram tram = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT id FROM tram WHERE rfidcode = :rfidcode");
                db.AddParameter("rfidcode", rfid);

                while (db.Read())
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

        //haal alle trams op en geeft een lijst van trams terug
        public static List<Tram> GetAll()
        {
            List<Tram> trams = new List<Tram>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT id FROM tram");
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;
                while (dr.Read())
                {
                    trams.Add(GetById(dr.GetValueByColumn<int>("id")));
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

            return trams;
        }
    }
}
