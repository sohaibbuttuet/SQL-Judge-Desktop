    using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class TestCaseDL
    {
        public static int AddTestCase(TestCase testCase)
        {
            string query = $"INSERT INTO TestCases (TestCaseName, ProblemID, SetupSQL SolutionQuery, IsActive) " +
                           $"VALUES ('{testCase.TestCaseName}', {testCase.ProblemID}, '{testCase.SetupSQL}', '{testCase.SolutionQuery}', {testCase.IsActive}); " +
                           "SELECT LAST_INSERT_ID();"; 

            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static void UpdateTestCase(TestCase testCase)
        {
            string query = $"UPDATE TestCases SET TestCaseName = '{testCase.TestCaseName}', " +
                           $"ProblemID = {testCase.ProblemID}, " +
                           $"SetupSQL = '{testCase.SetupSQL}'" +
                           $"SolutionQuery = '{testCase.SolutionQuery}', " +
                           $"IsActive = {testCase.IsActive} WHERE TestCaseID = {testCase.TestCaseID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static bool IsTestCaseExists(int problemID, int testCaseID, string testCaseName)
        {
            string query = $"SELECT COUNT(*) FROM testcases WHERE TestCaseID <> {testCaseID} AND TestCaseName = '{testCaseName}' AND ProblemID = {problemID};";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static bool IsTestCaseExists(int problemID, string testCaseName)
        {
            string query = $"SELECT COUNT(*) FROM testcases WHERE ProblemID = {problemID} AND TestCaseName = '{testCaseName}';";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
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
        public static List<TestCase> GetByProblemID(int problemID)
        {
            string query = $"SELECT * FROM TestCases WHERE ProblemID = {problemID};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

           List<TestCase> testCases = new List<TestCase>();
            foreach(DataRow row in dt.Rows)
            {
                testCases.Add(MapDataRowToTestCase(row));
            }

            return testCases;         
        }

        private static TestCase MapDataRowToTestCase(DataRow row)
        {
            return new TestCase
            (
                Convert.ToInt32(row["TestCaseID"]),
                row["TestCaseName"].ToString(),
                Convert.ToInt32(row["ProblemID"]),
                row["SetupSQL"].ToString(),
                row["SolutionQuery"].ToString(),
                Convert.ToInt32(row["CreatedBy"]),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToInt32(row["UpdatedBy"]),
                Convert.ToDateTime(row["UpdatedAt"]),
                Convert.ToBoolean(row["IsActive"])
            );
        }

        // Test Cases Panel for Admin Dashboard
        public static DataTable GetTestCases()
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
