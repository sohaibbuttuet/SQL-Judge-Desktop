using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class StudentLeaderboardDL
    {
        public static DataTable GetLeaderboard()
        {
            string query = "SELECT * FROM vw_studentsleaderboard;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int GetRank(int studentId)
        {
            string query = $"SELECT GlobalRank FROM vw_studentsleaderboard WHERE StudentID = {studentId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int GetTotalScore(int studentId)
        {
            string query = $"SELECT TotalScore FROM vw_studentsleaderboard WHERE StudentID = {studentId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int GetSolvedProblemsCount(int studentId)
        {
            string query = $"SELECT ProblemsSolved FROM vw_studentsleaderboard WHERE StudentID = {studentId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static string GetSkillLevel(int studentId)
        {
            string query = $"SELECT LevelName FROM vw_studentsleaderboard WHERE StudentID = {studentId};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Access the first row [0] and the column ["LevelName"]
                return dt.Rows[0]["LevelName"].ToString();
            }

            return "Unknown"; // Default value if student isn't found
        }
    }
}
