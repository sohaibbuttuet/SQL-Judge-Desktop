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
    internal class ContestDL
    {
        public static int CreateContest(Contest c)
        {
            string query = $"INSERT INTO Contests (Title, Description, StartDate, EndDate, CreatedBy, UpdatedBy) " + "VALUES (@Title, @Description, @StartDate, @EndDate, @CreatedBy, @UpdatedBy);" +
            $"SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Title", c.Title),
                new MySqlParameter("@Description", c.Description),
                new MySqlParameter("@StartDate", c.StartDate),
                new MySqlParameter("@EndDate", c.EndDate),
                new MySqlParameter("@CreatedBy", c.CreatedBy),
                new MySqlParameter("@UpdatedBy", c.UpdatedBy)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
        public static void UpdateContest(Contest c)
        {
            string query = $"UPDATE Contests SET Title = @Title, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, UpdatedBy = @UpdatedBy WHERE ContestID = @ContestID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Title", c.Title),
                new MySqlParameter("@Description", c.Description),
                new MySqlParameter("@StartDate", c.StartDate),
                new MySqlParameter("@EndDate", c.EndDate),
                new MySqlParameter("@UpdatedBy", c.UpdatedBy),
                new MySqlParameter("@ContestID", c.ContestID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static Contest GetContestByID(int contestid)
        {
            string query = $"SELECT * FROM Contests WHERE ContestID = @ContestID;";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestid)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToContest(dt.Rows[0]);
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
        public static DataTable GetAllContests()
        {
            string query = "SELECT * FROM vw_contests;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
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