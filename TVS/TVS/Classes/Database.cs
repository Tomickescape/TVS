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

        public T GetValueByColumn<T>(string column)
        {
            return DataReader.GetValueByColumn<T>(column);
        }
    }
}
