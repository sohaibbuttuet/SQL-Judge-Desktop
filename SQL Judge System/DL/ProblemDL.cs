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
                $"INSERT INTO Problems (Title, Description, DifficultyID, Points, TargetDatabase, MasterQuery, CreatedBy, UpdatedBy) " +
                $"VALUES(@Title, @Description, @DifficultyID, @Points, @TargetDatabase, @MasterQuery, @CreatedBy, @UpdatedBy); " +
                $"SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Title", problem.Title),
                new MySqlParameter("@Description", problem.Description),
                new MySqlParameter("@DifficultyID", problem.DifficultyID),
                new MySqlParameter("@Points", problem.Points),
                new MySqlParameter("@TargetDatabase", problem.TargetDatabase),
                new MySqlParameter("@MasterQuery", problem.MasterQuery),
                new MySqlParameter("@CreatedBy", problem.CreatedBy),
                new MySqlParameter("@UpdatedBy", problem.UpdatedBy),
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
        public static void UpdateProblem(Problem problem)
        {
            string query =
                $"UPDATE Problems SET Title = @Title, Description = @Description, DifficultyID = @DifficultyID, Points = @Points, TargetDatabase = @TargetDatabase, MasterQuery = @MasterQuery, UpdatedBy = @UpdatedBy WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Title", problem.Title),
                new MySqlParameter("@Description", problem.Description),
                new MySqlParameter("@DifficultyID", problem.DifficultyID),
                new MySqlParameter("@Points", problem.Points),
                new MySqlParameter("@TargetDatabase", problem.TargetDatabase),
                new MySqlParameter("@MasterQuery", problem.MasterQuery),
                new MySqlParameter("@UpdatedBy", problem.UpdatedBy),
                new MySqlParameter("@ProblemID", problem.ProblemID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
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
        public static bool IsProblemExists(int problemId)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE ProblemID = {problemId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static bool IsProblemExists(string title, int difficultyID)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE Title = @Title AND DifficultyID = @DifficultyID;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Title", title),
                new MySqlParameter("@DifficultyID", difficultyID)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }
        public static bool IsProblemExists(int problemID, string title, int difficultyID)
        {
            string query = $"SELECT COUNT(*) FROM Problems WHERE ProblemID <> @ProblemID AND Title = @Title AND DifficultyID = @DifficultyID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProblemID", problemID),
                new MySqlParameter("@Title", title),
                new MySqlParameter("@DifficultyID", difficultyID)
            };
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
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
                row["TargetDatabase"].ToString(),
                row["MasterQuery"].ToString(),
                Convert.ToInt32(row["CreatedBy"]),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToInt32(row["UpdatedBy"]),
                Convert.ToDateTime(row["UpdatedAt"]),
                 Convert.ToBoolean(row["IsActive"])
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
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable EasyProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems WHERE DifficultyName = 'Easy' Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable MediumProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems WHERE DifficultyName = 'Medium' Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable HardProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems WHERE DifficultyName = 'Hard' Order BY ProblemID;";
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
    }
}
