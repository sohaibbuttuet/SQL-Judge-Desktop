using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SQL_Judge_System.DL
{
    internal class DatabaseHelper
    {
        private String serverName = "127.0.0.1";
        private String port = "3306";
        private String databaseName = "sqljudgesystem";
        private String databaseUser = "root";
        private String databasePassword = "SohaibButt@16122006";

        private DatabaseHelper() { }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        private MySqlConnection getConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;";
            var connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        public int Update(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }
        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = getConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
        public int ExecuteScalar(string query)
        {
            using (var connection = getConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }
    }
}