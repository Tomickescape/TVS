using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace TramVerdeelSysteem__TVS_
{
    class Tram
    {

        private int _id;
        private int _segmentId;
        private Segment _segment;
        private bool _isSegmentLoaded = false;


        private Tram(int id, TramType type, int nummer, Status status, string rFIDCode, int lijnnr, int remiseID, int segmentId, bool aanwezig)
        {
            this._id = id;
            this.Type = type;
            this.Nummer = nummer;
            this.Status = status;
            this.RFIDCode = rFIDCode;
            this.LijnNR = lijnnr;
            this.RemiseID = remiseID;
            this._segmentId = segmentId;
            this.Aanwezig = aanwezig;
        }

        public TramType Type { get; private set; }
        public int Nummer { get; private set; }
        public Status Status { get; private set; }
        public string RFIDCode { get; private set; }
        public int LijnNR { get; private set; }
        public int RemiseID { get; private set; }
        public bool Aanwezig { get; private set; }

        public Segment Segment
        {
            get
            {
                if (!_isSegmentLoaded)
                {
                    _segment = TramVerdeelSysteem__TVS_.Segment.GetById(_segmentId);
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
                    else if (StringStatus == "Verontreinigf")
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
                    TramType type = (dr.GetValueByColumn<string>("tramtype")) == "c" ? TramType.Combino : TramType.Combino;
                     int nummer = (dr.GetValueByColumn<int>("tramnummer"));
                     string rfidcode = (dr.GetValueByColumn<string>("rfidcode"));
                     int lijnnr = (dr.GetValueByColumn<int>("lijnnr"));
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
