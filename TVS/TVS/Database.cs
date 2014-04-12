using System.Data;
// Database
using Oracle.DataAccess.Client;

namespace ftp_db_poc
{
    /// <summary>
    /// Class used for the database interaction in the application.
    /// </summary>
    public class Database
    {

        private OracleConnection conn;
        private OracleCommand cmd;
        private OracleDataReader dataReader;

        public Database()
        {
            conn = new OracleConnection("User Id=" + Properties.Settings.Default.db_user + ";Password=" + Properties.Settings.Default.db_pass + ";Data Source=" + "//" + Properties.Settings.Default.db_server + "/" + Properties.Settings.Default.db_name + ";");
            
        }

        public OracleDataReader DataReader { get { return dataReader; } }

        /// <summary>
        /// Opens the database connection.
        /// </summary>
        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        /// <summary>
        /// Closes the database connection.
        /// </summary>
        public void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Creates an command and binds it to the connection.
        /// </summary>
        /// <param name="commandText"></param>
        public void CreateCommand(string commandText)
        {
            cmd = conn.CreateCommand();
            cmd.BindByName = true;
            cmd.CommandText = commandText;
        }

        /// <summary>
        /// Binds a parameter to the command with the given value.
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        public void AddParameter(string parameterName, object value)
        {
            OracleParameter parameter = new OracleParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;

            cmd.Parameters.Add(parameter);
        }

        /// <summary>
        /// Executes the command and puts the results in the DataReader.
        /// </summary>
        /// <returns></returns>
        public bool ExecuteCommand()
        {            
            dataReader = cmd.ExecuteReader();
            if (dataReader != null)
            {
                return true;
            }
            return false;
        }

    }
}
