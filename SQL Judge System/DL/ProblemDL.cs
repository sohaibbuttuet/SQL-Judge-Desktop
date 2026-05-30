using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class ProblemDL
    {
        public static int AddProblem(Problem problem)
        {
            string query =
                $"INSERT INTO Problems (Title, Description, DifficultyID, Points, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt, IsActive) " +
                $"VALUES ('{problem.Title}', '{problem.Description}', {problem.DifficultyID}, {problem.Points}, " +
                $"{problem.CreatedBy}, '{problem.CreatedAt:yyyy-MM-dd HH:mm:ss}', {problem.CreatedBy}, " +
                $"'{problem.CreatedAt:yyyy-MM-dd HH:mm:ss}', {Convert.ToInt32(problem.IsActive)}); " +
                $"SELECT LAST_INSERT_ID();";

            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static void UpdateProblem(Problem problem)
        {
            string query =
                $"UPDATE Problems SET " +
                $"Title = '{problem.Title}', " +
                $"Description = '{problem.Description}', " +
                $"DifficultyID = {problem.DifficultyID}, " +
                $"Points = {problem.Points}, " +
                $"UpdatedBy = {problem.UpdatedBy}, " +
                $"UpdatedAt = '{problem.UpdatedAt:yyyy-MM-dd HH:mm:ss}' " +
                $"WHERE ProblemID = {problem.ProblemID};";

            DatabaseHelper.Instance.Update(query);
        }

        public static void UpdateProblemStatus(int problemID, bool isActive)
        {
            string query = $"UPDATE Problems SET IsActive = {Convert.ToInt32(isActive)} WHERE ProblemID = {problemID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static bool IsProblemExists(string title, int difficultyID)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE Title = '{title}' AND DifficultyID = {difficultyID};";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static bool IsProblemExists(int problemID, string title, int difficultyID)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE ProblemID <> {problemID} AND Title = '{title}' AND DifficultyID = {difficultyID};";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static Problem GetProblemByID(int problemID)
        {
            string query = $"SELECT * FROM problems WHERE ProblemID = {problemID}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count > 0)
            {
                return MapRowToProblem(dt.Rows[0]);
            }
            return null;
        }
        public static List<Problem> GetProblems()
        {
            string query = "SELECT * FROM Problems ORDER BY ProblemID;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Problem> problems = new List<Problem>();
            foreach (DataRow dr in dt.Rows)
            {
                problems.Add(MapRowToProblem(dr));
            }
            return problems;
        }

        // --- HELPER METHODS ---
        private static Problem MapRowToProblem(DataRow row)
        {
            return new Problem(

                Convert.ToInt32(row["ProblemID"]), 
                row["Title"].ToString(), 
                row["Description"].ToString(),
                Convert.ToInt32(row["DifficultyID"]),
                Convert.ToInt32(row["Points"]),
                Convert.ToBoolean(row["IsActive"]),
                Convert.ToInt32(row["CreatedBy"]),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToInt32(row["UpdatedBy"]),
                Convert.ToDateTime(row["UpdatedAt"])
            );
        }

        // Problem Panel in Admin Dashboard
        public static DataTable ProblemsList()
        {
            string query = "SELECT * FROM vw_problems Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalProblems()
        {
            string query = "SELECT COUNT(*) FROM Problems;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveProblems()
        {
            string query = "SELECT COUNT(*) FROM Problems WHERE IsActive = 1;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveProblems()
        {
            string query = "SELECT COUNT(*) FROM Problems WHERE IsActive = 0;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }

        // Student Panel Problems

        // only those problems will show that have test cases
        public static DataTable AllProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems JOIN TestCases USING(ProblemID) Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable EasyProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems JOIN TestCases USING(ProblemID) WHERE DifficultyName = 'Easy' Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable MediumProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems JOIN TestCases USING(ProblemID) WHERE DifficultyName = 'Medium' Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable HardProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems JOIN TestCases USING(ProblemID) WHERE DifficultyName = 'Hard' Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static string GetDescriptionByID(int problemID)
        {
            string query = $"SELECT Description FROM problems WHERE problemID = {problemID};";

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return "";

            return dt.Rows[0]["Description"].ToString();
        }

        public static bool IsProblemExists(int problemId)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE ProblemID = {problemId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static void ActivateProblem(int problemId)
        {
            string query = $"UPDATE Problems SET IsActive = 1 WHERE ProblemID = {problemId};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeactivateProblem(int problemId)
        {
            string query = $"UPDATE Problems SET IsActive = 0 WHERE ProblemID = {problemId};";
            DatabaseHelper.Instance.Update(query);
        }          
    }
}
