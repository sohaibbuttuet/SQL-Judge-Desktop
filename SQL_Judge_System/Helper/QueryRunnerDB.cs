using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

namespace SQL_Judge_System.Helper
{
    internal class QueryRunnerDB
    {
        private readonly string connectionString;

        public QueryRunnerDB(string databaseName)
        {
            if (string.IsNullOrWhiteSpace(databaseName))
                throw new ArgumentException("Target sandbox database schema name cannot be null or empty.", nameof(databaseName));

            // Fetch the secure base connection string from configuration
            string baseConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            // Safely inject the dynamic database name
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(baseConnectionString)
            {
                Database = databaseName
            };

            this.connectionString = builder.ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(this.connectionString);
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