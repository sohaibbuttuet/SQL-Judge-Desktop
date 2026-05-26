using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class ContestProblemDL
    {
        public static void AddProblem(ContestProblem contestProblem)
        {
            string query = $"INSERT INTO ContestProblems(contestID, problemID) " +
                           $"VALUES ({contestProblem.ContestID},{contestProblem.ProblemID});";

            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteProblem(ContestProblem contestProblem)
        {
            string query = $"DELETE FROM ContestProblems WHERE ContestID = {contestProblem.ContestID} AND ProblemID = {contestProblem.ProblemID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteProblemsByContestID(int contestID)
        {
            string query = $"DELETE FROM ContestProblems WHERE ContestID = {contestID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static bool IsProblemExistsinContest(ContestProblem contestProblem)
        {
            string query = $"SELECT COUNT(*) FROM ContestProblems WHERE ContestID = {contestProblem.ContestID} AND ProblemID = {contestProblem.ProblemID}";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static bool IsContestExists(int contestID)
        {
            string query = $"SELECT COUNT(*) FROM ContestProblems WHERE ContestID = {contestID};";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static List<ContestProblem> GetProblemsByContestID(int contestID)
        {
            string query = $"SELECT * FROM ContestProblems WHERE ContestID = {contestID};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ContestProblem> problems = new List<ContestProblem>();
            foreach (DataRow row in dt.Rows)
            {
                problems.Add(new ContestProblem((int)row["ContestID"], (int)row["problemID"]));
            }
            return problems;
        }
    }
}
