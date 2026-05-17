using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class ContestDL
    {
        public static int CreateContest(Contest c)
        {
            string query = $"INSERT INTO Contests (Title, Description, StartDate, EndDate, CreatedBy) " +
                           $"VALUES ('{c.Title}', '{c.Description}', '{c.StartDate:yyyy-MM-dd HH:mm:ss}', '{c.EndDate:yyyy-MM-dd HH:mm:ss}', {c.CreatedBy}); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateContest(Contest c)
        {
            string query = $"UPDATE Contests SET Title = '{c.Title}', Description = '{c.Description}', StartDate = '{c.StartDate:yyyy-MM-dd HH:mm:ss}', " +
                           $"EndDate = '{c.EndDate:yyyy-MM-dd HH:mm:ss}' WHERE ContestID = {c.ContestID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static Contest GetContestByID(int contestid)
        {
            string query = $"SELECT * FROM Contests WHERE ContestID = {contestid};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count < 0)
                return null;

            return MapDataRowToContest(dt.Rows[0]);
        }       
        public static bool IsContestExists(string Title)
        {
            string query = $"SELECT COUNT(*) FROM Contests WHERE Title = '{Title}';";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static bool IsContestExists(int contestID, string Title)
        {
            string query = $"SELECT COUNT(*) FROM Contests WHERE ContestID <> {contestID} AND Title = '{Title}'";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        private static Contest MapDataRowToContest(DataRow row)
        {
            return new Contest
            {
                ContestID = Convert.ToInt32(row["ContestID"]),
                Title = row["Title"].ToString(),
                Description = row["Description"].ToString(),
                StartDate = Convert.ToDateTime(row["StartDate"]),
                EndDate = Convert.ToDateTime(row["EndDate"]),
                CreatedBy = Convert.ToInt32(row["CreatedBy"])
            };
        }

        // Contests in Admin Dashboard
        public static DataTable GetAllContests()
        {
            string query = "SELECT * FROM vw_contests;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalContests()
        {
            string query = "SELECT COUNT(*) FROM vw_contests;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveContests()
        {
            string query = "SELECT COUNT(*) FROM vw_contests WHERE ContestStatus = 'Active';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveContests()
        {
            string query = "SELECT COUNT(*) FROM vw_contests WHERE ContestStatus = 'Ended';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int UpcomingContests()
        {
            string query = "SELECT COUNT(*) FROM vw_contests WHERE ContestStatus = 'Upcoming';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}