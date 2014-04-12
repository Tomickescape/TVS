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

        private int _lijnId;
        private Lijn _lijn;



        private Tram(int id, string type, int nummer, Status status, string rFIDCode, int lijnId, int remiseID, int segmentId, bool aanwezig)
        {
            _lijnId = lijnId;
            _segmentId = segmentId;

            Id = id;
            Type = type;
            Nummer = nummer;
            Status = status;
            RFIDCode = rFIDCode;
            RemiseID = remiseID;
            Aanwezig = aanwezig;
        }

        public int Id { get; private set; }
        public string Type { get; private set; }
        public int Nummer { get; private set; }
        public Status Status { get; private set; }
        public string RFIDCode { get; private set; }

        public Lijn Lijn
        {
            get
            {
                if (_lijn == null)
                {
                    _lijn = Lijn.GetById(_lijnId);
                }
                return _lijn;
            }
        }
        public int RemiseID { get; private set; }
        public bool Aanwezig { get; private set; }

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
                    if (StringStatus == "Aanwezig")
                    {
                        status = Status.Aanwezig;
                    }
                    else if (StringStatus == "Afwezig")
                    {
                        status = Status.Afwezig;
                    }
                    else if (StringStatus == "Defect")
                    {
                        status = Status.Defect;
                    }
                    else if (StringStatus == "Verontreinigd")
                    {
                        status = Status.Verontreinigd;
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
                    int lijnId = (dr.GetValueByColumn<int>("lijn_id"));
                    int remiseId = (dr.GetValueByColumn<int>("remise_id"));
                    int segmentId = (dr.GetValueByColumn<int>("segment_id"));
                    bool aanwezig = (dr.GetValueByColumn<int>("aanwezig")) > 0;
                    tram = new Tram(id, type, nummer, status, rfidcode, lijnId, remiseId, segmentId, aanwezig);

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
