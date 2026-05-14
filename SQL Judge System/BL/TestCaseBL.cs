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
            if(testCase == null)
            {
                throw new ArgumentNullException(nameof(testCase));
            }
            if(testCase.ProblemID <= 0)
            {
                throw new ArgumentException("ProblemID must be greater than zero.");
            }
            if(string.IsNullOrWhiteSpace(testCase.SetupSQL) || string.IsNullOrWhiteSpace(testCase.ExpectedOutput))
            {
                throw new ArgumentException("SetupSQL and ExpectedOutput cannot be null or empty.");
            }
            testCase.TestCaseID = TestCasesDL.AddTestCase(testCase);
        }
        public static void UpdateTestCase(TestCase testCase)
        {
            if (testCase == null)
            {
                throw new ArgumentNullException(nameof(testCase));
            }
            if (testCase.TestCaseID <= 0)
            {
                throw new ArgumentException("TestCaseID must be greater than zero.");
            }
            if (testCase.ProblemID <= 0)
            {
                throw new ArgumentException("ProblemID must be greater than zero.");
            }
            if (string.IsNullOrWhiteSpace(testCase.SetupSQL) || string.IsNullOrWhiteSpace(testCase.ExpectedOutput))
            {
                throw new ArgumentException("SetupSQL and ExpectedOutput cannot be null or empty.");
            }
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
        public static DataTable GetTestCasesForAdmin()
        {
            return TestCasesDL.GetTestCasesForAdmin();
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
