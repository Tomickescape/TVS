using System;
using System.Data;
// Database
using Oracle.DataAccess.Client;

namespace TVS
{
    /// <summary>
    /// Class used for the database interaction in the application.
    /// </summary>
    public class Database
    {

        private OracleConnection conn;
        private OracleCommand cmd;

        public Database()
        {
            try
            {
                //haal alle gegevens uit het settings bestand, username ,password etc.
                conn = new OracleConnection();
                conn.ConnectionString = "User Id=" + Properties.Settings.Default.db_user + ";Password=" +
                                        Properties.Settings.Default.db_pass + ";Data Source=" + "//" +
                                        Properties.Settings.Default.db_server + "/" +
                                        Properties.Settings.Default.db_name + ";";
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }


        public bool HasRows { get { return DataReader.HasRows; } }

        public OracleDataReader DataReader { get; private set; }

        //opn de connection als die nog niet open is.
        public void Open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }


        //sluit de connectie als deze nog niet gesloten is
        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        //maak een commando aan
        public void CreateCommand(string commandText)
        {
            cmd = conn.CreateCommand();
            cmd.BindByName = true;
            cmd.CommandText = commandText;
        }

        //geef deze parameters door 
        public void AddParameter(string parameterName, object value)
        {
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;

            cmd.Parameters.Add(parameter);
        }


        //voer het commando uit
        public void Execute()
        {
            if (cmd == null)
            {
                throw new Exception("No command initiated.");
            }
            if (conn.State != ConnectionState.Open)
            {
                Open();
            }
            DataReader = cmd.ExecuteReader();
        }


        public bool Read()
        {
            if (DataReader == null)
            {
                Execute();
            }

            return DataReader.Read();
        }
        //haalt de waarde op door middel van het gegeven column door middel van het gespecificeerde type
        public T GetValueByColumn<T>(string column)
        {
            return DataReader.GetValueByColumn<T>(column);
        }
    }
}
