using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace SQL_Judge_System.DL
{
    internal class QueryRunnerDB
    {
        private readonly string databaseName;

        public QueryRunnerDB(string databaseName)
        {
            this.databaseName = databaseName;
        }

        private MySqlConnection GetConnection()
        {
            string connectionString =
                $"server=127.0.0.1;" +
                $"port=3306;" +
                $"user=root;" +
                $"database={databaseName};" +
                $"password=SohaibButt@16122006;" +
                $"SslMode=Required;" +
                $"Pooling=False;";

            return new MySqlConnection(connectionString);
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }
    }
}