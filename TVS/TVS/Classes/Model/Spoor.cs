using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS
{
    public class Spoor
    {

        public Spoor(int id, bool geblokkeerd, int nummer)
        {
            Id = id;
            Geblokkeerd = geblokkeerd;
            Nummer = nummer;
        }

        public int Id { get; private set; }

        public List<Segment> Segments
        {
            get
            {
                return Segment.GetBySpoornummer(Nummer);
            }
        }


        public bool Geblokkeerd { get; set; }
        public int Nummer { get; set; }

        public void ToggleGeblokkeerd()
        {
            ChangeGeblokkeerd(!Geblokkeerd);
        }

        public void ChangeGeblokkeerd(bool geblokkeerd)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE spoor SET status = :status WHERE id = :id");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("Id", Id);
                db.Open();
                db.Execute();
                db.Close();

                foreach (Segment segment in Segments)
                {
                    segment.ChangeGeblokkeerd(geblokkeerd);
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

        public static Spoor GetBySpoornummer(int nummer)
        {
            Spoor spoor = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM spoor WHERE nummer = :nummer");
                db.AddParameter("nummer", nummer);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;

                if (dr.HasRows)
                {
                    dr.Read();
                    bool blokkeerStatus = dr.GetValueByColumn<string>("status") == "geblokkeerd";

                    spoor = new Spoor(dr.GetValueByColumn<int>("id"), blokkeerStatus, dr.GetValueByColumn<int>("nummer"));
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

        public static Spoor GetById(int id)
        {
            Spoor spoor = null;

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT * FROM spoor WHERE id = :id");
                db.AddParameter("id", id);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;

                if (dr.HasRows)
                {
                    dr.Read();
                    bool geblokkeerd = dr.GetValueByColumn<string>("status") == "geblokkeerd";

                    spoor = new Spoor(dr.GetValueByColumn<int>("id"), geblokkeerd, dr.GetValueByColumn<int>("nummer"));
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
