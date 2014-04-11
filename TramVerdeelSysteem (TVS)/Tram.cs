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

        private Segment segment;
        private bool isSegmentLoaded = false;


        private Tram(int tramId, string tramtype, int tramNummer, Status status, string rFIDCode, int lijnnr, int remiseID, int segment, int statusaanwezig)
        {
            this.TramId = tramId;
            this.TramType = tramtype;
            this.TramNummer = tramNummer;
            this.Status = status;
            this.RFIDCode = rFIDCode;
            this.LijnNR = lijnnr;
            this.RemiseID = remiseID;
            this.SegmentID = segment;
            this.StatusAanwezig = statusaanwezig;
        }

        public int TramId { get; private set; }
        public string TramType { get; private set; }
        public int TramNummer { get; private set; }
        public Status Status { get; private set; }
        public string RFIDCode { get; private set; }
        public int LijnNR { get; private set; }
        public int RemiseID { get; private set; }
        public int SegmentID { get; private set; }
        public int StatusAanwezig { get; private set; }

        public Segment Segment
        {
            get
            {
                if (!isSegmentLoaded)
                {
                    segment = TramVerdeelSysteem__TVS_.Segment.GetById(SegmentID);
                    isSegmentLoaded = true;
                }
                return segment;
            }
        }

        public static Tram GetById(int id)
        {
            Tram tram = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM tram WHERE tramid = :id");
                db.AddParameter("id", id);
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
                     int tramid = (dr.GetValueByColumn<int>("tramid"));
                     string tramtype = (dr.GetValueByColumn<string>("tramtype"));
                     int tramnummer = (dr.GetValueByColumn<int>("tramnummer"));
                     string rfidcode = (dr.GetValueByColumn<string>("rfidcode"));
                     int lijnnr = (dr.GetValueByColumn<int>("lijnnr"));
                     int remiseid = (dr.GetValueByColumn<int>("remiseid"));
                     int segmentid = (dr.GetValueByColumn<int>("segmentid"));
                     int statusaanwezig = (dr.GetValueByColumn<int>("statusaanwezig"));
                     tram = new Tram(tramid, tramtype, tramnummer, status, rfidcode, lijnnr, remiseid, segmentid, statusaanwezig);

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
