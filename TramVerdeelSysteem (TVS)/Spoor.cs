using System.Windows.Forms;
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

        public Spoor(bool geblokkeerd, int spoornummer)
        {
            Geblokkeerd = geblokkeerd;
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


        public bool Geblokkeerd { get; set; }
        public int Spoornummer { get; set; }

        public void ChangeStatus(bool geblokkeerd)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE spoor SET spoorstatus = :status WHERE spoornummer = :spoornummer");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("spoornummer", Spoornummer);
                db.Open();
                db.Execute();
                db.Close();

                foreach (Segment segment in Segments)
                {
                    segment.ChangeStatus(geblokkeerd);
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
                    bool blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus") == "geblokkeerd";

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
