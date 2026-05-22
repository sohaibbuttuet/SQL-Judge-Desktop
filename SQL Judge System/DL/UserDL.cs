using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.DL
{
    internal class UserDL
    {
        public static int SignUp(User user)
        {
            string query = $"INSERT INTO Users (FullName, Email, Password, IsActive, CreatedAt) " +
                           $"VALUES ('{user.FullName}', '{user.Email}', '{user.Password}', {user.IsActive}, '{user.CreatedAt:yyyy-MM-dd HH:mm:ss}'); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateUser(User user)
        {
            string query = $"UPDATE Users SET FullName = '{user.FullName}', Email = '{user.Email}', Password = '{user.Password}' WHERE UserID = {user.UserID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static User SignIn(string email, string password)
        {
            string query = $"SELECT * FROM Users WHERE Email = '{email}' AND Password = '{password}' AND IsActive = 1;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if(dt.Rows.Count == 0 )
                return null;

            return MapDataRowToUser(dt.Rows[0]);
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

        public static bool IsEmailRegistered(string email)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE Email = '{email}';";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }
        public static bool IsEmailRegistered(int userID, string email)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID <> {userID} AND Email = '{email}';";
            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }

        public static bool IsUserExists(int userId)
        {
            string query = $"SELECT COUNT(*) FROM Users WHERE UserID = {userId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }

        public static bool IsUserAdmin(int userId)
        {
            string query = $"SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Admin' AND UserID = {userId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static bool IsUserSuperAdmin(int userId)
        {
            string query = $"SELECT COUNT(*) FROM vw_users WHERE RoleName = 'SuperAdmin' AND UserID = {userId};";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }        

        public static User GetUserByID(int userId)
        {
            string query = $"SELECT * FROM Users WHERE UserID = {userId};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;
            return MapDataRowToUser(dt.Rows[0]);
        }


        // Helper Function
        private static User MapDataRowToUser(DataRow row)
        {
            return new User(Convert.ToInt32(row["UserID"]), row["FullName"].ToString(), row["Email"].ToString(), row["Password"].ToString(), Convert.ToBoolean(row["IsActive"]), Convert.ToDateTime(row["CreatedAt"]), Convert.ToDateTime(row["UpdatedAt"]));
        }

        // ----------------------------------------------------------------------- //
        // SuperAdmin Panel
        public static DataTable GetAdminList()
        {
            string query = "SELECT * FROM vw_users WHERE RoleName = 'Admin' ORDER BY UserID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }      
        public static int TotalAdmins()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Admin';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int TotalSuperAdmins()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'SuperAdmin';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveAdmins()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Admin' AND IsActive = 1;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveAdmins()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Admin' AND IsActive = 0;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }

        // Admin Home Panel
        public static DataTable GetUsers()
        {
            string query = "SELECT * FROM vw_users ORDER BY UserID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalUsers()
        {
            string query = "SELECT COUNT(*) FROM vw_users;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveUsers()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE IsActive = 1;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveUsers()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE IsActive = 0;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        // ----------------------------------------------------------------------- //


    }
}