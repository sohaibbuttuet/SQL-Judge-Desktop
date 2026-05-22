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
            string query = $"INSERT INTO Contests (Title, Description, StartDate, EndDate, CreatedBy, CreatedAt, UpdatedBy, UpdatedAt) " +
                           $"VALUES ('{c.Title}', '{c.Description}', '{c.StartDate:yyyy-MM-dd HH:mm:ss}', '{c.EndDate:yyyy-MM-dd HH:mm:ss}', {c.CreatedBy}, '{c.CreatedAt:yyyy-MM-dd HH:mm:ss}', {c.CreatedBy}, '{c.CreatedAt:yyyy-MM-dd HH:mm:ss}'); " +
                           $"SELECT LAST_INSERT_ID();";

            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static void UpdateContest(Contest c)
        {
            string query = $"UPDATE Contests SET Title = '{c.Title}', Description = '{c.Description}', StartDate = '{c.StartDate:yyyy-MM-dd HH:mm:ss}', " +
                           $"EndDate = '{c.EndDate:yyyy-MM-dd HH:mm:ss}', UpdatedBy = {c.UpdatedBy}, UpdatedAt = '{c.UpdatedAt:yyyy-MM-dd HH:mm:ss}' WHERE ContestID = {c.ContestID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static Contest GetContestByID(int contestid)
        {
            string query = $"SELECT * FROM Contests WHERE ContestID = {contestid};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToContest(dt.Rows[0]);
        }       

        public static DataTable GetAllContests()
        {
            string query = "SELECT * FROM vw_contests;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        // Helping Function
        private static Contest MapDataRowToContest(DataRow row)
        {
            return new Contest(
                Convert.ToInt32(row["ContestID"]),
                row["Title"].ToString(),
                row["Description"].ToString(),
                Convert.ToDateTime(row["StartDate"]),
                Convert.ToDateTime(row["EndDate"]),
                Convert.ToInt32(row["CreatedBy"]),
                Convert.ToDateTime(row["CreatedAt"]),
                Convert.ToInt32(row["UpdatedBy"]),
                Convert.ToDateTime(row["UpdatedAt"])
            );
        }

        // Validation Function
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

        // Contests in Admin Dashboard
        public static int TotalContests()
        {
            string query = "SELECT COUNT(*) FROM Contests;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveContests()
        {
            string query = "SELECT COUNT(*) FROM Contests WHERE NOW() BETWEEN StartDate AND EndDate;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveContests()
        {
            string query = "SELECT COUNT(*) FROM Contests WHERE NOW() > EndDate;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int UpcomingContests()
        {
            string query = "SELECT COUNT(*) FROM Contests WHERE NOW() < StartDate; ";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}