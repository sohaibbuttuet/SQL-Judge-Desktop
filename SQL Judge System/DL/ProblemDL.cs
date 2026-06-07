using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.DL
{
    internal class ProblemDL
    {
        // ==========================================
        // CORE CRUD OPERATIONS
        // ==========================================
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

        // ==========================================
        // STATUS ACTIONS 
        // ==========================================
        public static void ActivateProblem(int problemId)
        {
            string query = "UPDATE Problems SET IsActive = 1 WHERE ProblemID = @ProblemID;";
            MySqlParameter[] parameters = { new MySqlParameter("@ProblemID", problemId) };
            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static void DeactivateProblem(int problemId)
        {
            string query = "UPDATE Problems SET IsActive = 0 WHERE ProblemID = @ProblemID;";
            MySqlParameter[] parameters = { new MySqlParameter("@ProblemID", problemId) };
            DatabaseHelper.Instance.Update(query, parameters);
        }

        // ==========================================
        // VALIDATION FUNCTIONS
        // ==========================================
        public static bool IsProblemExists(int problemId)
        {
            string query = "SELECT COUNT(*) FROM Problems WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters = { new MySqlParameter("@ProblemID", problemId) };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }
        public static bool IsProblemExists(string title, int difficultyID)
        {
            string query = "SELECT COUNT(*) FROM Problems WHERE Title = @Title AND DifficultyID = @DifficultyID;";

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

        // ==========================================
        // DATA RETRIEVAL
        // ==========================================
        public static Problem GetProblemByID(int problemID)
        {
            string query = "SELECT * FROM Problems WHERE ProblemID = @ProblemID;";
            MySqlParameter[] parameters = { new MySqlParameter("@ProblemID", problemID) };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

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
        public static DataTable GetContestProblems(int contestID)
        {
            string query = "CALL contestProblems(@ContestID);";
            MySqlParameter[] parameters = { new MySqlParameter("@ContestID", contestID) };
            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static DataTable ProblemsList()
        {
            string query = "SELECT * FROM vw_problems Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        // ==========================================
        // DATA ROW MAPPING 
        // ==========================================
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

        // ==========================================
        // STUDENT INTERFACE GRID VIEWS
        // ==========================================
        public static DataTable AllProblemsList()
        {
            string query = "SELECT ProblemID, Title, DifficultyName FROM vw_problems Order BY ProblemID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
