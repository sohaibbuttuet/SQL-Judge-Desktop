using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SQL_Judge_System.Helper
{
    internal class QueryRunnerDB
    {
        private readonly string databaseName;
        private readonly string serverName = "127.0.0.1";
        private readonly string port = "3306";
        private readonly string databaseUser = "root";
        private readonly string databasePassword = "SohaibButt@16122006";

        public QueryRunnerDB(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("Target sandbox database schema name cannot be null or empty.", nameof(databaseName));

            this.databaseName = databaseName;
        }

        private MySqlConnection GetConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};" +
                                     $"database={databaseName};password={databasePassword};SslMode=Required;";

            return new MySqlConnection(connectionString);
        }

        // ==========================================
        // FETCH SANDBOXED STUDENT RESULT DATATABLE
        // ==========================================
        public DataTable GetDataTable(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                throw new ArgumentException("Execution query cannot be empty.", nameof(query));

            DataTable dt = new DataTable();

            using (var connection = GetConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}