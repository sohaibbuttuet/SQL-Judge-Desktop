using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Documents;

namespace SQL_Judge_System.BL
{
    internal class QueryRunnerBL
    {
        public static void ValidateQuery(string targetDatabase, string query)
        {
            if (string.IsNullOrWhiteSpace(targetDatabase))
                throw new ArgumentException("Target schema database context cannot be null or empty.");

            // 1. Clean and validate the query to ensure it is a single, read-only statement without dangerous keywords
            query = CleanAndValidateQuery(query);

            // 2. Attempt to execute the query to ensure it runs without syntax errors and returns a dataset structure
            QueryRunnerDB runnerDb = new QueryRunnerDB(targetDatabase);
            DataTable dt = runnerDb.GetDataTable(query);

            if (dt == null)
                throw new Exception("Failed to execute query or no dataset structure returned.");
        }
        public static string CleanAndValidateQuery(string sql)
        {
            // Clean up whitespace and remove any trailing semicolon typed by the user
            string cleanedSql = sql.Trim();

            if (cleanedSql.EndsWith(";"))
                cleanedSql = cleanedSql.Substring(0, cleanedSql.Length - 1).Trim();

            string lowerSql = cleanedSql.ToLower();

            // Guard: Empty query check
            if (string.IsNullOrWhiteSpace(cleanedSql))
                throw new ArgumentException("SQL Query cannot be empty.");

            // Guard: Block multi-statement queries to prevent injection breakouts
            if (cleanedSql.Contains(";"))
                throw new ArgumentException("Multiple SQL statements are not allowed.");

            // Guard: Ensure it only executes read-only queries
            if (!lowerSql.StartsWith("select") && !lowerSql.StartsWith("with"))
                throw new ArgumentException("Only SELECT queries are allowed.");            

            // Safe Keyword Blocklist: Uses word boundaries (\b) so words like 'Walter' or 'Creative' work!
            string[] blockedKeywords = { "drop", "alter", "delete", "truncate", "update", "insert", "create", "exec", "merge", "replace", "rename" };

            foreach (string keyword in blockedKeywords)
            {
                // \b ensures match on full words only
                if (Regex.IsMatch(lowerSql, $@"\b{keyword}\b"))
                {
                    throw new ArgumentException($"Restricted SQL operation detected: '{keyword}' is blocked.");
                }
            }

            return cleanedSql;
        }
    }
}
