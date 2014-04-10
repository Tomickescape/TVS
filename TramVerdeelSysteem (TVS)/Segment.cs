using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TramVerdeelSysteem__TVS_
{
    class Segment
    {

        private int id;

        private Segment(int id, bool geblokkeerd, int segmentnummer, int spoornummer, string special)
        {
            this.id = id;
            Geblokkeerd = geblokkeerd;
            Segmentnummer = segmentnummer;
            Spoornummer = spoornummer;
            Special = special;
        }

        public int Segmentnummer { get; set; }
        public bool Geblokkeerd { get; set; }
        public int Spoornummer { get; private set; }
        public Tram Tram { get; private set; }
        public string Special { get; private set; }

        public void ChangeStatus(bool geblokkeerd)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE segment SET spoorstatus = :status WHERE segmentid = :id");
                db.AddParameter("status", geblokkeerd ? "geblokkeerd" : "vrij");
                db.AddParameter("id", id);
                db.Open();
                db.Execute();
                db.Close();

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

        public static Segment GetBySegmentnummerAndSpoornummer(int segmentnummer, int spoornummer)
        {
            Segment segment = null;
            
            Database db = new Database();

            try
            {
                db.CreateCommand(
                    "SELECT segment.* FROM SEGMENT LEFT JOIN SPOOR ON spoor.spoorID = segment.spoorID WHERE spoor.spoornummer = :spoornummer and segment.segmentnummer = :segmentnummer");
                db.AddParameter("spoornummer", spoornummer);
                db.AddParameter("segmentnummer", segmentnummer);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;
                if (dr.HasRows)
                {
                    dr.Read();
                    bool blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus") == "geblokkeerd";

                    segment = new Segment(dr.GetValueByColumn<int>("segmentid"), blokkeerStatus, dr.GetValueByColumn<int>("segmentnummer"), spoornummer, dr.GetValueByColumn<string>("special"));
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
            return segment;
        }

        public static List<Segment> GetBySpoornummer(int spoornummer)
        {
            List<Segment> segments = new List<Segment>();

            Database db = new Database();

            try
            {
                db.CreateCommand("SELECT segment.* FROM segment JOIN spoor ON spoor.spoorID = segment.spoorID WHERE spoor.spoornummer = :spoornummer");
                db.AddParameter("spoornummer", spoornummer);
                db.Open();
                db.Execute();
                OracleDataReader dr = db.DataReader;
                while(dr.Read())
                {
                    segments.Add(GetBySegmentnummerAndSpoornummer(dr.GetValueByColumn<int>("segmentnummer"), spoornummer));
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

            return segments;
        }
        
    }
}
