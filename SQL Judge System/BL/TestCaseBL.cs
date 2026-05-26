using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;
using System.Data;

namespace SQL_Judge_System.BL
{
    internal class TestCaseBL
    {
        public static void AddTestCase(TestCase testCase)
        {
            ValidateTestCase(testCase);

            if (TestCasesDL.IsTestCaseExists(testCase.ProblemID, testCase.TestCaseName))
                throw new ArgumentException("Test Case already exists for this Problem.");

            testCase.TestCaseID = TestCasesDL.AddTestCase(testCase);
        }
        public static void UpdateTestCase(TestCase testCase)
        {
            ValidateTestCase(testCase);

            if (TestCasesDL.IsTestCaseExists(testCase.ProblemID, testCase.TestCaseID, testCase.TestCaseName))
                throw new ArgumentException("Test Case already exists for this Problem.");

            TestCasesDL.UpdateTestCase(testCase);
        }
        public static void ActivateTestCase(int testCaseID)
        {
            if (testCaseID <= 0)
            {
                throw new ArgumentException("TestCaseID must be greater than zero.");
            }
            TestCasesDL.ActivateTestCase(testCaseID);
        }
        public static void DeactivateTestCase(int testCaseID)
        {
            if (testCaseID <= 0)
            {
                throw new ArgumentException("TestCaseID must be greater than zero.");
            }
            TestCasesDL.DeactivateTestCase(testCaseID);
        }

        // Helping Function
        public static void ValidateTestCase(TestCase testCase)
        {
            if (testCase == null)
                throw new ArgumentNullException(nameof(testCase));

            // Problem validation
            if (testCase.ProblemID <= 0)
                throw new ArgumentException("ProblemID must be greater than zero.");

            // Test case name
            if (string.IsNullOrWhiteSpace(testCase.TestCaseName))
                throw new ArgumentException("Test case name is required.");

            // Setup SQL validation
            if (string.IsNullOrWhiteSpace(testCase.SetupSQL))
                throw new ArgumentException("Setup SQL cannot be empty.");

            string setupSql = testCase.SetupSQL.Trim().ToLower();

            if (!(setupSql.StartsWith("create") || setupSql.StartsWith("insert")))
                throw new ArgumentException("Setup SQL must start with CREATE or INSERT.");

            string[] blockedKeywords = { "drop", "alter", "delete", "truncate", "update" };

            if (blockedKeywords.Any(k => setupSql.Contains(k)))
                throw new ArgumentException("Setup SQL contains restricted operations.");

            // Solution Query validation
            if (string.IsNullOrWhiteSpace(testCase.SolutionQuery))
                throw new ArgumentException("Solution Query cannot be empty.");

            string solutionSql = testCase.SolutionQuery.Trim().ToLower();

            if (!solutionSql.StartsWith("select"))
                throw new ArgumentException("Solution Query must start with SELECT.");

            if (blockedKeywords.Any(k => solutionSql.Contains(k)))
                throw new ArgumentException("Solution Query contains restricted operations.");

            // Name length safety
            if (testCase.TestCaseName.Length > 100)
                throw new ArgumentException("Test case name is too long.");
        }

        // Test Cases Panel for Admin Dashboard
        public static DataTable GetTestCases()
        {
            return TestCasesDL.GetTestCases();
        }
        public static int TotalTestCases()
        {
            return TestCasesDL.TotalTestCases();
        }
        public static int ActiveTestCases()
        {
            return TestCasesDL.ActiveTestCases();
        }
        public static int InactiveTestCases()
        {
            return TestCasesDL.InactiveTestCases();
        }
    }
}
