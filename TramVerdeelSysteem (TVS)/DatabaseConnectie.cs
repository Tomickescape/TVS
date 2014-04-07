using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Windows.Forms;


namespace TramVerdeelSysteem__TVS_
{
    class DatabaseConnectie
    {
        private OracleConnection conn;

        //opent de database connectie

        OracleDataReader myReader;
        //lokaal mark
        //string oracleGebruikersnaam = "Mark";
        //string oracleWachtwoord = "mark";
        //lokaal mick
        string oracleGebruikersnaam = "tomick";
        string oracleWachtwoord = "mick123";
        OracleCommand SelectCommand;


        public void OpenConnection()
        {
            conn = new OracleConnection();

            conn.ConnectionString = "User Id=" + oracleGebruikersnaam + ";Password=" + oracleWachtwoord + ";Data Source=" + " //127.0.0.1:1521" + ";";
            conn.Open();

        }

        public bool Inlog(string gebruikersnaam, string wachtwoord)
        {
            OpenConnection();
            //mark 
            SelectCommand = new OracleCommand("select * from Tomick.GEBRUIKER where GEBRUIKERSNAAM='" + gebruikersnaam + "' and WACHTWOORD = '" + wachtwoord + "'", conn);
            //tomick     
            //OracleCommand SelectCommand = new OracleCommand("select GEBRUIKERSNAAM, WACHTWOORD from Tomick.GEBRUIKER where GEBRUIKERSNAAM='" + gebruikersnaam + "' and WACHTWOORD = '" + wachtwoord + "'", conn);
            myReader = SelectCommand.ExecuteReader();
            int count = 0;
            while (myReader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                closeConnection();
                return true;
            }
            else
            {
                closeConnection();
                throw new Exception("Gebruikersnaam en wachtwoord zijn niet bekend.");
            }
        }
        //sluit de database connectie
        public void closeConnection()
        {
            conn.Close();
        }
        // blokkeert een spoor

        public void VeranderSpoorStatus(string status, int spoornummer)
        {
            conn = new OracleConnection();
            try
            {
                OpenConnection();
                OracleCommand SelectCommand = new OracleCommand("Update spoor set status = ('" + status + "') where spoornummer = " + spoornummer, conn);
                SelectCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Er ging iets mis met het maken van de connectie met de database!");
            }
            finally
            {
                closeConnection();
            }
        }

        public void VeranderSegmentStatus(string status, int segmentnummer)
        {
            conn = new OracleConnection();
            try
            {
                OpenConnection();
                OracleCommand SelectCommand = new OracleCommand("Update segment set status = ('" + status + "') where segmentnummer = " + segmentnummer, conn);
                SelectCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Er ging iets mis met het maken van de connectie met de database!");
            }
            finally
            {
                closeConnection();
            }
        }
  
        public static Spoor GetSpoorBySpoornummer(int spoornummer)
        {
            Spoor spoor = null;
            DatabaseConnectie db = new DatabaseConnectie();
            db.OpenConnection();
            OracleCommand cmd = new OracleCommand("SELECT spoor.* FROM tomick.spoor WHERE tomick.spoor.spoornummer = " + spoornummer, db.conn);

           // OracleCommand cmd = new OracleCommand("SELECT spoor.*,segment.*FROM tomick.spoor LEFT JOIN tomick.segment ON tomick.segment.spoorID = tomick.spoor.spoorID WHERE tomick.spoor.spoornummer = " + spoornummer + "'", db.conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus");

                spoor = new Spoor(blokkeerStatus, dr.GetValueByColumn<int>("spoornummer"));
            }
            db.closeConnection();

            return spoor;
        }

        public static Segment GetBySegmentnummerAndSpoornummer(int segmentnummer, int spoornummer)
        {
            Segment segment = null;
            DatabaseConnectie db = new DatabaseConnectie();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT segment.* FROM tomick.SEGMENT LEFT JOIN tomick.SPOOR ON tomick.spoor.spoorID = tomick.segment.spoorID WHERE tomick.spoor.spoornummer = " + spoornummer + "and tomick.segment.segmentnummer = " + segmentnummer, db.conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
               string  blokkeerStatus = dr.GetValueByColumn<string>("spoorstatus");

               segment = new Segment(blokkeerStatus, dr.GetValueByColumn<int>("segmentnummer"), spoornummer);
            }
            db.closeConnection();

            return segment;
        }

        public static List<Segment> GetBySegmentBySpoornummer(int spoornummer)
        {
            List<Segment> segments = null;
            DatabaseConnectie db = new DatabaseConnectie();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT segment.segmentid AS id FROM tomick.SEGMENT LEFT JOIN tomick.SPOOR ON tomick.spoor.spoorID = tomick.segment.spoorID WHERE tomick.spoor.spoornummer = " + spoornummer, db.conn);

            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                segments.Add(GetBySegmentnummerAndSpoornummer(dr.GetValueByColumn<int>("id"), spoornummer));
            }
            db.closeConnection();
            return segments;
        }

        public static Tram Get(int segmentnummer, int tramnummer)
        {
            Tram tram = null;
            DatabaseConnectie db = new DatabaseConnectie();
            db.OpenConnection();

            OracleCommand cmd = new OracleCommand("SELECT tram.* FROM tomick.SEGMENT LEFT JOIN tomick.SPOOR ON tomick.spoor.spoorID = tomick.segment.spoorID WHERE tomick.spoor.spoornummer = '" + tramnummer + "'", db.conn);
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                bool geblokkeerd = dr.GetValueByColumn<string>("spoorstatus") == "geblokkeerd" ? true : false;

               // tram = new Tram(geblokkeerd,tramnummer);
            }

            db.closeConnection();

            return tram;
        }
    }
}
