using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace SQL_Judge_System.Helper
{
    internal class DatabaseHelper
    {
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
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new MySqlConnection(connectionString);
        }

        // Accepts an optional parameter array
        public int Update(string query, MySqlParameter[] parameters = null)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    // If parameters were passed, attach them to the command safely
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Accepts an optional parameter array
        public DataTable GetDataTable(string query, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        // Accepts an optional parameter array
        public int ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    object result = command.ExecuteScalar();

                    if (result == null || result == DBNull.Value)
                        return -1;

                    return Convert.ToInt32(result);
                }
            }
        }

        // Accepts an optional parameter array
        public object ExecuteScalarObject(string query, MySqlParameter[] parameters = null)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteScalar();
                }
            }
        }
    }
}