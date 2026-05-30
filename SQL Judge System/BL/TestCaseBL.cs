using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class TestCaseBL
    {
        public static void AddTestCase(TestCase testCase)
        {
            // 1. Run structural, safety, and policy validation constraints
            ValidateTestCase(testCase);

            // 2. IMMEDIATE RUNTIME VALIDATION (If it fails, execution halts instantly!)
            try
            {
                // Run both the setup and the solution query together. 
                DataTable testResult = QueryRunnerDB.Instance.ExecuteTransactionViaSql(testCase.SetupSQL, testCase.SolutionQuery);

                // Ensure the solution actually returned records
                if (testResult == null)
                {
                    throw new ArgumentException("The validation test run returned a null payload object.");
                }
            }
            catch (Exception dbEx)
            {
                // Catch any MySQL syntax, table initialization, or constraint exceptions
                throw new ArgumentException($"Database Validation Execution Failed!\n\nReason: {dbEx.Message}");
            }

            // 3. Prevent duplicate names within the same problem space
            if (TestCaseDL.IsTestCaseExists(testCase.ProblemID, testCase.TestCaseName))
                throw new ArgumentException("A Test Case with this name already exists for this chosen Problem.");

            // 4. Only add if the transaction validation completed with zero failures
            testCase.TestCaseID = TestCaseDL.AddTestCase(testCase);
        }
        public static void UpdateTestCase(TestCase testCase)
        {
            ValidateTestCase(testCase);

            if (TestCaseDL.IsTestCaseExists(testCase.ProblemID, testCase.TestCaseID, testCase.TestCaseName))
                throw new ArgumentException("Test Case already exists for this Problem.");

            TestCaseDL.UpdateTestCase(testCase);
        }
        public static void ActivateTestCase(int testCaseID)
        {
            if (testCaseID <= 0)
            {
                throw new ArgumentException("TestCaseID must be greater than zero.");
            }
            TestCaseDL.ActivateTestCase(testCaseID);
        }
        public static void DeactivateTestCase(int testCaseID)
        {
            if (testCaseID <= 0)
            {
                throw new ArgumentException("TestCaseID must be greater than zero.");
            }
            TestCaseDL.DeactivateTestCase(testCaseID);
        }
        public static List<TestCase> GetByProblemID(int problemID)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            return TestCaseDL.GetByProblemID(problemID);
        }

        // Validation Functions
        public static void ValidateTestCase(TestCase testCase)
        {
            if (testCase == null)
                throw new ArgumentNullException(nameof(testCase));

            if (testCase.ProblemID <= 0)
                throw new ArgumentException("ProblemID must be greater than zero.");

            if (string.IsNullOrWhiteSpace(testCase.TestCaseName) || testCase.TestCaseName.Length > 100)
                throw new ArgumentException("Test case name must be valid and cannot exceed 100 characters.");

            // 1. Validate Setup SQL (Throws policy exception internally if invalid)            
            testCase.SetupSQL = ValidateSetupSQL(testCase.SetupSQL);

            // 2. Clean and Validate Solution Query (Throws policy exception internally if invalid) 
            testCase.SolutionQuery = QueryRunnerBL.CleanAndValidateQuery(testCase.SolutionQuery);
        }
        public static string ValidateSetupSQL(string setupSql)
        {
            // 1. Guard against empty or null input strings
            if (string.IsNullOrWhiteSpace(setupSql))
                throw new ArgumentException("Setup SQL script cannot be empty.");

            // Clean it up right away
            string cleanedSql = setupSql.Trim();
            string lowerSql = cleanedSql.ToLower();

            // 2. Enforce the Temporary Table policy rule
            if (lowerSql.Contains("create table") && !lowerSql.Contains("create temporary table"))
            {
                throw new ArgumentException(
                    "Security Policy Mismatch:\n\n" +
                    "Regular tables ('CREATE TABLE') are restricted to prevent database pollution.\n" +
                    "Please rewrite your schema definition using 'CREATE TEMPORARY TABLE'."
                );
            }

            // 3. Block permanent structure modifications on the Judge System database itself
            string[] restrictedAdminKeywords = { "drop database", "create database", "alter database", "grant", "revoke" };
            foreach (string keyword in restrictedAdminKeywords)
            {
                if (Regex.IsMatch(lowerSql, $@"\b{keyword}\b"))
                {
                    throw new ArgumentException($"Restricted Administrative keyword detected: '{keyword}' is blocked.");
                }
            }

            // 4. Ensure the setup script actually creates some context
            if (!lowerSql.Contains("create temporary table") && !lowerSql.Contains("insert into"))
            {
                throw new ArgumentException(
                    "Invalid Setup Script:\n\n" +
                    "A valid environment setup script must contain at least one 'CREATE TEMPORARY TABLE' " +
                    "or 'INSERT INTO' operation to build a dataset for testing."
                );
            }

            // Return the cleaned string instead of a boolean!
            return cleanedSql;
        }

        // Test Cases Panel for Admin Dashboard
        public static DataTable GetTestCases()
        {
            return TestCaseDL.GetTestCases();
        }
        public static int TotalTestCases()
        {
            return TestCaseDL.TotalTestCases();
        }
        public static int ActiveTestCases()
        {
            return TestCaseDL.ActiveTestCases();
        }
        public static int InactiveTestCases()
        {
            return TestCaseDL.InactiveTestCases();
        }
    }
}
