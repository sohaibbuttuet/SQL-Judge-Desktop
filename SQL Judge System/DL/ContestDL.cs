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
            string query = $"INSERT INTO Contests (Title, Description, StartDate, EndDate, StatusID, CreatedBy) " +
                           $"VALUES ('{c.Title}', '{c.Description}', '{c.StartDate:yyyy-MM-dd HH:mm:ss}', '{c.EndDate:yyyy-MM-dd HH:mm:ss}', {c.StatusID}, {c.CreatedBy}); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateContest(Contest c)
        {
            string query = $"UPDATE Contests SET Title = '{c.Title}', Description = '{c.Description}', StartDate = '{c.StartDate:yyyy-MM-dd HH:mm:ss}', " +
                           $"EndDate = '{c.EndDate:yyyy-MM-dd HH:mm:ss}', StatusID = {c.StatusID} WHERE ContestID = {c.ContestID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteContest(int contestID)
        {
            string query = $"DELETE FROM Contests WHERE ContestID = {contestID};";
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
        public static List<Contest> GetAllContests()
        {
            string query = "SELECT * FROM Contests;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Contest> contests = new List<Contest>();
            foreach (DataRow row in dt.Rows)
            {
                contests.Add(MapDataRowToContest(row));
            }
            return contests;
        }
        public static int TotalContests()
        {
            string query = "SELECT COUNT(*) FROM Contests;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
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
                StatusID = Convert.ToInt32(row["StatusID"]),
                CreatedBy = Convert.ToInt32(row["CreatedBy"])
            };
        }
    }
}
