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
        public static DataTable GetOutput(int problemID, string query)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            // 1. Clean and validate student query text
            query = CleanAndValidateQuery(query);

            // 2. Get All Test Cases of the Problem
            var testCases = TestCaseDL.GetByProblemID(problemID);
            if (testCases == null || testCases.Count == 0)
                throw new Exception("This problem does not have any test cases configured yet.");

            // 3. Run Query against first test case's setupsql
            string setupsql = testCases[0].SetupSQL;
            DataTable studentResult = QueryRunnerDB.Instance.ExecuteTransactionViaSql(setupsql, query);

            return studentResult;
        }
        public static string CleanAndValidateQuery(string sql)
        {
            // Clean up whitespace and remove any trailing semicolon typed by the student
            string cleanedSql = sql.Trim();
            if (cleanedSql.EndsWith(";"))
            {
                cleanedSql = cleanedSql.Substring(0, cleanedSql.Length - 1).Trim();
            }

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
