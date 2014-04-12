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
                db.CreateCommand("SELECT * FROM tram WHERE tramid = :id");
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
                    int id = (dr.GetValueByColumn<int>("tramid"));
                    string type = (dr.GetValueByColumn<string>("tramtype"));
                    int nummer = (dr.GetValueByColumn<int>("tramnummer"));
                    string rfidcode = (dr.GetValueByColumn<string>("rfidcode"));
                    int lijnnr = (dr.GetValueByColumn<int>("lijnId"));
                    int remiseid = (dr.GetValueByColumn<int>("remiseid"));
                    int segmentId = (dr.GetValueByColumn<int>("segmentid"));
                    bool aanwezig = (dr.GetValueByColumn<int>("statusaanwezig")) > 0;
                    tram = new Tram(id, type, nummer, status, rfidcode, lijnnr, remiseid, segmentId, aanwezig);

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
                db.CreateCommand("SELECT tramid FROM tram");
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;
                while (dr.Read())
                {
                    trams.Add(GetById(dr.GetValueByColumn<int>("tramid")));
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
