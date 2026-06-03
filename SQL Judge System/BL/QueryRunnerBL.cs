using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Documents;

namespace SQL_Judge_System.BL
{
    internal class QueryRunnerBL
    {
        // This method serves as the main entry point for executing a student's SQL query. It performs a series of critical steps to ensure the query is safe, valid, and adheres to the constraints of the problem before executing it against the database. The steps include cleaning and validating the query format, checking that it only references allowed tables, and then executing it using the QueryRunnerDB class to retrieve the results.
        public static DataTable ExecuteQuery(string targetDatabase, string query, List<string> allowedTableNames)
        {
            if (string.IsNullOrWhiteSpace(targetDatabase))
                throw new ArgumentException("Target schema database context cannot be null or empty.");

            // 1. Clean and validate the query format and structure
            query = CleanAndValidateQuery(query);

            // 2. Validate structural table accessibility constraints
            IsQueryRestrictedToAllowedTables(query, targetDatabase, allowedTableNames);

            // 3. Execute the validated query against the database engine
            QueryRunnerDB runnerDb = new QueryRunnerDB(targetDatabase);
            return runnerDb.GetDataTable(query);
        }

        // This method performs  cleaning and validation of the student's SQL query to ensure it adheres to the expected format and does not contain any potentially harmful operations. It checks for empty queries, removes trailing semicolons, guards against multi-statement execution, ensures the query is read-only (SELECT or WITH), and blocks any usage of restricted keywords that could modify the database or execute arbitrary code.
        public static string CleanAndValidateQuery(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql))
                throw new ArgumentException("SQL Query cannot be empty.");

            string cleanedSql = sql.Trim();

            // Strip out trailing semicolons safely
            if (cleanedSql.EndsWith(";"))
                cleanedSql = cleanedSql.Substring(0, cleanedSql.Length - 1).Trim();

            // Guard: Block multi-statement execution breakouts
            if (cleanedSql.Contains(";"))
                throw new ArgumentException("Multiple SQL statements are not allowed.");

            string lowerSql = cleanedSql.ToLower();

            // Guard: Ensure read-only processing
            if (!lowerSql.StartsWith("select") && !lowerSql.StartsWith("with"))
                throw new ArgumentException("Only SELECT queries are allowed.");

            // Safe Keyword Blocklist
            string[] blockedKeywords = { "drop", "alter", "delete", "truncate", "update", "insert", "create", "exec", "merge", "replace", "rename" };

            foreach (string keyword in blockedKeywords)
            {
                if (Regex.IsMatch(lowerSql, $@"\b{keyword}\b"))
                {
                    throw new ArgumentException($"Restricted SQL operation detected: '{keyword}' is blocked.");
                }
            }

            return cleanedSql;
        }

        // Validates that the student's query does not reference any tables outside of the allowed list for this problem. This is done by fetching the full list of tables in the database and ensuring none of the forbidden tables are mentioned in the query.
        private static void IsQueryRestrictedToAllowedTables(string studentQuery, string databaseName, List<string> allowedTables)
        {
            string cleanQuery = studentQuery.ToUpper().Trim();

            // Fetch the total list of tables existing in the database schema
            List<string> allDatabaseTables = SchemaDL.GetAllTables(databaseName);

            // Isolate forbidden structural tables
            var forbiddenTables = allDatabaseTables.Except(allowedTables, StringComparer.OrdinalIgnoreCase);

            foreach (string forbiddenTable in forbiddenTables)
            {
                string upperForbidden = forbiddenTable.ToUpper();

                // Regex handles matching variations safely: "forbiddenTable", "database.forbiddenTable"
                string pattern = $@"\b({databaseName.ToUpper()}\.)?{upperForbidden}\b";

                if (Regex.IsMatch(cleanQuery, pattern))
                {
                    throw new ArgumentException($"Access to table '{forbiddenTable}' is restricted for this problem.");
                }
            }
        }
    }
}
