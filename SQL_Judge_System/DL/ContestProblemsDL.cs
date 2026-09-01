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
    internal class ContestProblemsDL
    {
        public static void AddProblem(ContestProblem contestProblem)
        {
            string query = "INSERT INTO ContestProblems (ContestID, ProblemID) VALUES (@ContestID, @ProblemID);";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestProblem.ContestID),
                new MySqlParameter("@ProblemID", contestProblem.ProblemID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static void DeleteProblemsByContestID(int contestID)
        {
            string query = "DELETE FROM ContestProblems WHERE ContestID = @ContestID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static bool IsProblemExistsinContest(ContestProblem contestProblem)
        {
            string query = "SELECT COUNT(*) FROM ContestProblems WHERE ContestID = @ContestID AND ProblemID = @ProblemID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestProblem.ContestID),
                new MySqlParameter("@ProblemID", contestProblem.ProblemID)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static bool IsContestExists(int contestID)
        {
            string query = "SELECT COUNT(*) FROM ContestProblems WHERE ContestID = @ContestID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestID)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static int CountContestProblems(int contestID)
        {
            string query = "SELECT COUNT(*) FROM contestProblems WHERE ContestID = @contestID";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@contestID", contestID)
            };

            int result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);

            return result != -1 ? result : 0;
        }
        public static List<ContestProblem> GetProblemsByContestID(int contestID)
        {
            string query = "SELECT * FROM ContestProblems WHERE ContestID = @ContestID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestID)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            List<ContestProblem> problems = new List<ContestProblem>();

            foreach (DataRow row in dt.Rows)
            {
                problems.Add(new ContestProblem(
                    Convert.ToInt32(row["ContestID"]),
                    Convert.ToInt32(row["ProblemID"]))
                );
            }
            return problems;
        }
    }
}
