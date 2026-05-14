using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class TestCasesDL
    {
        public static int AddTestCase(TestCase testCase)
        {
            string query = $"INSERT INTO TestCases (ProblemID, SetupSQL, ExpectedOutput, IsActive) " +
                           $"VALUES ({testCase.ProblemID}, {testCase.SetupSQL}, {testCase.ExpectedOutput} {testCase.IsActive}); " +
                           "SELECT LAST_INSERT_ID();"; 
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static void UpdateTestCase(TestCase testCase)
        {
            string query = $"UPDATE TestCases SET ProblemID = {testCase.ProblemID}, " +
                           $"SetupSQL = {testCase.SetupSQL}, ExpectedOutput = {testCase.ExpectedOutput}, " +
                           $"IsActive = {testCase.IsActive} WHERE TestCaseID = {testCase.TestCaseID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void ActivateTestCase(int testCaseID)
        {
            string query = $"UPDATE TestCases SET IsActive = 1 WHERE TestCaseID = {testCaseID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeactivateTestCase(int testCaseID)
        {
            string query = $"UPDATE TestCases SET IsActive = 0 WHERE TestCaseID = {testCaseID};";
            DatabaseHelper.Instance.Update(query);
        }

        public static DataTable GetTestCasesForAdmin()
        {
            string query = "SELECT * FROM vw_testcases;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalTestCases()
        {
            string query = "SELECT COUNT(*) FROM TestCases;";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int ActiveTestCases()
        {
            string query = "SELECT COUNT(*) FROM TestCases WHERE IsActive = 1;";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int InactiveTestCases()
        {
            string query = "SELECT COUNT(*) FROM TestCases WHERE IsActive = 0;";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
    }
}
