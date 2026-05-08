using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class UserDL
    {
        public static int SignUp(User user)
        {
            string query = $"INSERT INTO Users (Email, Password) " +
                           $"VALUES ('{user.Email}', '{user.Password}'); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateUser(User user, string previousEmail)
        {
            string query = $"UPDATE Users SET Email = '{user.Email}', Password = '{user.Password}' WHERE Email = '{previousEmail}';";
            DatabaseHelper.Instance.Update(query);
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
        public static int GetUserIdByCredentials(string email, string password)
        {
            string query = $"SELECT UserID FROM Users WHERE Email = '{email}' AND Password = '{password}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int TotalAdmins()
        {
            string query = "SELECT COUNT(*) " +
                           "FROM users u " +
                           "JOIN userroles ur ON u.UserID = ur.UserID " +
                           "JOIN roles r ON ur.RoleID = r.RoleID " +
                           "WHERE r.RoleName = 'admin';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveAdmins()
        {
            string query = "SELECT COUNT(*) " +
                           "FROM users u " +
                           "JOIN userroles ur ON u.UserID = ur.UserID " +
                           "JOIN roles r ON ur.RoleID = r.RoleID " +
                           "WHERE r.RoleName = 'admin' " +
                           "AND u.IsActive = 1;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveAdmins()
        {
            string query = "SELECT COUNT(*) " +
                           "FROM users u " +
                           "JOIN userroles ur ON u.UserID = ur.UserID " +
                           "JOIN roles r ON ur.RoleID = r.RoleID " +
                           "WHERE r.RoleName = 'admin' " +
                           "AND u.IsActive = 0;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }

        // Helper Function
        private static User MapDataRowToUser(DataRow row)
        {
            return new User
            {
                UserID = Convert.ToInt32(row["UserID"]),
                Email = row["Email"].ToString(),
                Password = row["PasswordHash"].ToString(),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // Validation Functions
        public static bool ValidateUserCredentials(User user)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Email = '{user.Email}' AND Password = '{user.Password}' AND IsActive = 1;";
            int count = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public static bool IsEmailRegistered(string email)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Email = '{email}';";
            int count = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
            return count > 0;
        }
        public static bool IsUserExists(int userId)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID = {userId} AND IsActive = 1;";  
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static bool IsUserAdmin(int userId)
        {
            string query = $"SELECT COUNT(*) FROM userroles ur JOIN roles r ON ur.RoleID = r.RoleID WHERE ur.UserID = {userId} AND r.RoleName = 'admin';"; 
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
    }
}