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

        public Spoor(int id, int nummer, int lijnnummer1, int lijnnummer2)
        {
            Id = id;
            Nummer = nummer;
            Lijnnummer1 = lijnnummer1;
            Lijnnummer2 = lijnnummer2;
        }

        public int Id { get; private set; }

        public List<Segment> Segments
        {
            get
            {
                return Segment.GetBySpoornummer(Nummer);
            }
        }

        public int Lijnnummer1 { get; set; }
        public int Lijnnummer2 { get; set; }

        public bool Geblokkeerd
        {
            get
            {
                foreach (Segment segment in Segments)
                {
                    if (!segment.Geblokkeerd)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public int Nummer { get; set; }



        public Segment FirstSegmentAvailableForTram(Tram tram)
        {
            Segment eersteSegment = null;

            if (tram.Lijnen.Count > 0)
            {
                if (tram.Lijnen.Find(x => x == Lijnnummer1) == 0 && tram.Lijnen.Find(x => x == Lijnnummer2) == 0)
                {
                    return null;
                }
            }

            foreach (Segment segment in Segments)
            {
                if (!segment.Geblokkeerd && segment.Special != "permanent" && segment.CheckUitrij(tram))
                {
                    if (segment.Tram == null || (segment.Tram.Id == tram.Id))
                    {
                        if (eersteSegment == null || segment.Nummer < eersteSegment.Nummer)
                        {
                            eersteSegment = segment;
                        }
                    }
                }
            }
            return eersteSegment;
        }

        public void ChangeGeblokkeerd(bool geblokkeerd)
        {
            Segment segmentSelected = null;

            foreach (Segment segment in Segments)
            {
                if (segmentSelected == null || segment.Nummer > segmentSelected.Nummer)
                {
                    segmentSelected = segment;
                }
            }

            segmentSelected.ChangeGeblokkeerdAndLowerNummers(!Geblokkeerd);
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

                    spoor = new Spoor(dr.GetValueByColumn<int>("id"), dr.GetValueByColumn<int>("nummer"), dr.GetValueByColumn<int>("lijnnummer1"), dr.GetValueByColumn<int>("lijnnummer2"));
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

                    spoor = new Spoor(dr.GetValueByColumn<int>("id"), dr.GetValueByColumn<int>("nummer"),dr.GetValueByColumn<int>("lijnnummer1"), dr.GetValueByColumn<int>("lijnnummer2"));
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
