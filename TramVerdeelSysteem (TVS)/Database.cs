using System;
using System.Data;
// Database
using Oracle.DataAccess.Client;

namespace TramVerdeelSysteem__TVS_
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
            conn = new OracleConnection("User Id=" + Properties.Settings.Default.db_user + ";Password=" + Properties.Settings.Default.db_pass + ";Data Source=" + "//" + Properties.Settings.Default.db_server + "/" + Properties.Settings.Default.db_name + ";");
        }

        public OracleDataReader DataReader { get; private set; }

        public void Open()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public void CreateCommand(string commandText)
        {
            cmd = conn.CreateCommand();
            cmd.BindByName = true;
            cmd.CommandText = commandText;
        }

        public void AddParameter(string parameterName, object value)
        {
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;

            cmd.Parameters.Add(parameter);
        }

        public bool Execute()
        {
            if (cmd != null)
            {
                throw new Exception("No command initiated.");
            }
            DataReader = cmd.ExecuteReader();
            if (DataReader != null)
            {
                return true;
            }
            return false;
        }

    }
}
