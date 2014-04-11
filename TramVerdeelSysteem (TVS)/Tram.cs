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
        private int segmentId;
        private Segment segment;
        private bool isSegmentLoaded = false;
        
        private Tram(int tramId, int tramtype, int tramNummer, Status status, string rFIDCode, int lijnID, int remiseID)
        {
            this.TramId = tramId;
            this.TramType = tramtype;
            this.TramNummer = tramNummer;
            this.Status = status;
            this.RFIDCode = rFIDCode;
            this.LijnID = lijnID;
            this.RemiseID = remiseID;
        }

        public int TramId { get; private set; }
        public int TramType { get; private set; }
        public int TramNummer { get; private set; }
        public Status Status { get; private set; }
        public string RFIDCode { get; private set; }
        public int LijnID { get; private set; }
        public int RemiseID { get; private set; }
       
        public Segment Segment
        {
            get
            {
                if (!isSegmentLoaded)
                {
                    segment = TramVerdeelSysteem__TVS_.Segment.GetById(segmentId);
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
                    tram = new Tram(dr.GetValueByColumn<int>("tramid"), dr.GetValueByColumn<int>("tramtype"), dr.GetValueByColumn<int>("tramnummer"), dr.GetValueByColumn<Status>("status"), dr.GetValueByColumn<string>("rfidcode"), dr.GetValueByColumn<int>("lijnid"), dr.GetValueByColumn<int>("remiseid"));
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
