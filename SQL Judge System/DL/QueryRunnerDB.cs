using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace SQL_Judge_System.DL
{
    internal class QueryRunnerDB
    {
        private string serverName = "127.0.0.1";
        private string port = "3306";
        private string databaseName = "Query_Runner";
        private string databaseUser = "root";
        private string databasePassword = "SohaibButt@16122006";

        private static QueryRunnerDB _instance;

        public static QueryRunnerDB Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QueryRunnerDB();
                return _instance;
            }
        }

        private MySqlConnection getConnection()
        {
            string connectionString = $"server={serverName};port={port};user={databaseUser};database={databaseName};password={databasePassword};SslMode=Required;Pooling=False;";

            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteStudentSubmission(string setupSql, string studentQuery)
        {
            DataTable dt = new DataTable();

            // 1. Dynamic Cleanup Injection to stop consecutive "Table already exists" crashes
            if (!string.IsNullOrWhiteSpace(setupSql))
            {
                Match match = Regex.Match(setupSql, @"(?:TEMPORARY\s+TABLE|TABLE)\s+(\w+)", RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    string tableName = match.Groups[1].Value;
                    setupSql = $"DROP TEMPORARY TABLE IF EXISTS {tableName};\n" + setupSql;
                }
            }

            using (var connection = getConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    // 2. Isolated Setup Environment Execution
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(setupSql))
                        {
                            using (var setupCommand = new MySqlCommand(setupSql, connection, transaction))
                            {
                                setupCommand.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Rollback and throw a custom isolated exception identifier for the BL to catch
                        transaction.Rollback();
                        throw new InvalidOperationException("SETUP_FAULT");
                    }

                    // 3. Student Query Execution
                    try
                    {
                        using (var queryCommand = new MySqlCommand(studentQuery, connection, transaction))
                        {
                            using (var reader = queryCommand.ExecuteReader())
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw; // Re-throw the original SQL syntax mistake made by the student
                    }

                    // Clean up session context memory
                    transaction.Rollback();
                }
            }

            // Force ADO.NET connection pools to discard remaining temporary table cache metadata
            MySqlConnection.ClearAllPools();

        return dt;
    }
        public DataTable ExecuteTransactionViaSql(string setupSql, string solutionQuery, MySqlParameter[] setupParameters = null, MySqlParameter[] studentParameters = null)
        {
            DataTable dt = new DataTable();

            using (var connection = getConnection())
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Run setup SQL (Creates temporary tables and inserts mock records)
                        if (!string.IsNullOrWhiteSpace(setupSql))
                        {
                            using (var setupCommand = new MySqlCommand(setupSql, connection, transaction))
                            {
                                // Attach setup parameters safely if they exist
                                if (setupParameters != null)
                                {
                                    setupCommand.Parameters.AddRange(setupParameters);
                                }
                                setupCommand.ExecuteNonQuery();
                            }
                        }

                        // 2. Run student's query and collect output data
                        using (var queryCommand = new MySqlCommand(solutionQuery, connection, transaction))
                        {
                            // Attach student parameters safely if they exist
                            if (studentParameters != null)
                            {
                                queryCommand.Parameters.AddRange(studentParameters);
                            }

                            using (var reader = queryCommand.ExecuteReader())
                            {
                                dt.Load(reader); // Safeguard: dt.Load closes the reader automatically
                            }
                        }

                        // 3. Undo all changes safely to keep the sandbox database completely pristine
                        transaction.Rollback();
                    }
                    catch
                    {
                        try { transaction.Rollback(); }
                        catch { /* Ignore secondary fallback rollback failures */ }
                        throw;
                    }
                }
            }

            return dt;
        }
    }
}