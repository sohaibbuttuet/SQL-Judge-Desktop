using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidDb26_2025CS259;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class UserDL
    {
        public static int AddUser(User user)
        {
            string query = $"INSERT INTO Users (Email, PasswordHash, IsActive, CreatedAt) " +
                           $"VALUES ('{user.Email}', '{user.PasswordHash}', {user.IsActive}, '{user.CreatedAt}'); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateUser(User user)
        {
            string query = $"UPDATE Users SET Email = '{user.Email}', PasswordHash = '{user.PasswordHash}' WHERE UserID = {user.UserID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static User GetUserById(int userId)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {userId};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToUser(dt.Rows[0]);

        }
        public static User GetUserByEmail(string email)
        {
            string query = $"SELECT * FROM Users WHERE Email = '{email}';";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToUser(dt.Rows[0]);
        }
        public static List<User> GetAllUsers()
        {
            string query = "SELECT * FROM Users;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(MapDataRowToUser(row));
            }
            return users;
        }
        public static List<User> GetActiveUsers()
        {
            string query = "SELECT * FROM Users WHERE IsActive = 1;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(MapDataRowToUser(row));
            }

            return users;
        }
        public static List<User> GetInactiveUsers()
        {
            string query = "SELECT * FROM Users WHERE IsActive = 0;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<User> users = new List<User>();
            foreach (DataRow row in dt.Rows)
            {
                users.Add(MapDataRowToUser(row));
            }
            return users;
        }
        public static void ActivateUser(int userId)
        {
            string query = $"UPDATE Users SET IsActive = 1 WHERE UserID = {userId};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeactivateUser(int userId)
        {
            string query = $"UPDATE Users SET IsActive = 0 WHERE UserID = {userId};";
            DatabaseHelper.Instance.Update(query);
        }

        // Helper Function
        private static User MapDataRowToUser(DataRow row)
        {
            return new User
            {
                UserID = Convert.ToInt32(row["UserID"]),
                Email = row["Email"].ToString(),
                PasswordHash = row["PasswordHash"].ToString(),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // Validation Functions
        public static bool ValidateUserCredentials(string email, string passwordHash)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Email = '{email}' AND PasswordHash = '{passwordHash}' AND IsActive = 1;";
            int count = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public static bool IsEmailRegistered(string email)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Email = '{email}';";
            int count = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public static bool IsUserActive(int userId)
        {
            string query = $"SELECT IsActive FROM Users WHERE UserID = {userId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) == 1; // 1 for true, 0 for false
        }
        public static bool IsUserExists(int userId)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID = {userId};";  
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
    }
}