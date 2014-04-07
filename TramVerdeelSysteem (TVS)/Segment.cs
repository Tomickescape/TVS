using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;

namespace TramVerdeelSysteem__TVS_
{
    class Segment
    {

        public Segment(string blokkeerStatus, int segmentnummer, int spoornummer)
        {
            BlokkeerStatus = blokkeerStatus;
            Segmentnummer = segmentnummer;
            Spoornummer = spoornummer;

        }

        public int Segmentnummer { get; set; }
        public string BlokkeerStatus { get; set; }
        public int Spoornummer { get; private set; }
        public Tram Tram { get; private set; }

        public void ChangeStatus(string status)
        {
            Database db = new Database();
            try
            {
                db.CreateCommand("UPDATE segment SET status = :status WHERE segmentnummer = :segmentnummer");
                db.AddParameter("status", status);
                db.AddParameter("segmentnummer", Segmentnummer);
                db.Open();
                db.Execute();
                db.Close();

                BlokkeerStatus = status;
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
                    string blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus");

                    segment = new Segment(blokkeerStatus, dr.GetValueByColumn<int>("segmentnummer"), spoornummer);
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
                db.CreateCommand("SELECT segment.segmentid AS id FROM segment LEFT JOIN SPOOR ON spoor.spoorID = segment.spoorID WHERE spoor.spoornummer = :spoornummer");
                db.AddParameter("spoornummer", spoornummer);
                db.Open();
                db.Execute(); 
                
                OracleDataReader dr = db.DataReader;
                if (dr.HasRows)
                {
                    dr.Read();
                    segments.Add(GetBySegmentnummerAndSpoornummer(dr.GetValueByColumn<int>("id"), spoornummer));
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
