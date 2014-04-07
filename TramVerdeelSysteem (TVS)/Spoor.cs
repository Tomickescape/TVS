using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramVerdeelSysteem__TVS_
{
    class Spoor
    {
        private List<Segment> segments = null; 

        public Spoor(string blokkeerStatus, int spoornummer)
        {
            BlokkeerStatus = blokkeerStatus;
            Spoornummer = spoornummer;
        }

        public List<Segment> Segments
        {
            get
            {
                if (segments == null)
                {
                    segments = Segment.GetBySpoornummer(Spoornummer);
                }
                return segments;
            }
        }


        public string BlokkeerStatus { get; set; }
        public int Spoornummer { get; set; }

        public void ChangeStatus(string status)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE spoor SET status = :status WHERE spoornummer = :spoornummer");
                db.AddParameter("status", status);
                db.AddParameter("spoornummer", Spoornummer);
                db.Open();
                db.Execute();
                db.Close();

                BlokkeerStatus = status;

                foreach (Segment segment in Segments)
                {
                    segment.ChangeStatus(BlokkeerStatus);
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

        public static Spoor GetBySpoornummer(int spoornummer)
        {
            Spoor spoor = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM spoor WHERE spoornummer = :spoornummer");
                db.AddParameter("spoornummer", spoornummer);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;

                if (dr.HasRows)
                {
                    dr.Read();
                    string blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus");

                    spoor = new Spoor(blokkeerStatus, dr.GetValueByColumn<int>("spoornummer"));
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

            return spoor;
        }
    }
}
