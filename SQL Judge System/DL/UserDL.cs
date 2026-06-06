using MySql.Data.MySqlClient;
using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using SQL_Judge_System.UI;
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
        // ==========================================
        // AUTHENTICATION & PROFILE CREATION
        // ==========================================
        public static int SignUp(User user)
        {
            string query = "INSERT INTO Users (FullName, Email, Password, IsActive) " +
                           "VALUES (@FullName, @Email, @Password, @IsActive); " +
                           "SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@Email", user.Email),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@IsActive", user.IsActive ? 1 : 0)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
        }
        public static void UpdateUser(User user)
        {
            string query = "UPDATE Users SET FullName = @FullName, Email = @Email, Password = @Password WHERE UserID = @UserID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@Email", user.Email),
                new MySqlParameter("@Password", user.Password),
                new MySqlParameter("@UserID", user.UserID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static void UpdateProfile(User user)
        {
            string query = "UPDATE Users SET FullName = @FullName, Email = @Email WHERE UserID = @UserID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@FullName", user.FullName),
                new MySqlParameter("@Email", user.Email),
                new MySqlParameter("@UserID", user.UserID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static User SignIn(string email, string password)
        {
            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password AND IsActive = 1;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Email", email),
                new MySqlParameter("@Password", password)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if(dt.Rows.Count == 0)
                return null;

            return MapDataRowToUser(dt.Rows[0]);
        }
        public static bool VerifyPassword(int userID, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@Password", password)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static void ChangePassword(int userID, string password)
        {
            string query = "UPDATE Users SET Password = @Password WHERE UserID = @UserID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@Password", password),
                new MySqlParameter("@UserID", userID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static User GetUserByID(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userId) };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return MapDataRowToUser(dt.Rows[0]);
        }

        // ==========================================
        // HELPING FUNCTIONS
        // ==========================================
        private static User MapDataRowToUser(DataRow row)
        {
            return new User(Convert.ToInt32(row["UserID"]), row["FullName"].ToString(), row["Email"].ToString(), row["Password"].ToString(), Convert.ToBoolean(row["IsActive"]), Convert.ToDateTime(row["CreatedAt"]), Convert.ToDateTime(row["UpdatedAt"]));
        }

        // ==========================================
        // VALIDATION LOOKUPS
        // ==========================================
        public static bool IsEmailRegistered(string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email;";
            MySqlParameter[] parameters = { new MySqlParameter("@Email", email) };
            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static bool IsEmailRegistered(int userID, string email)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserID <> @UserID AND Email = @Email;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@UserID", userID),
                new MySqlParameter("@Email", email)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static bool IsUserExists(int userId)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userId) };
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }
        public static bool IsUserSuperAdmin(int userId)
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'SuperAdmin' AND UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userId) };
            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }

        // ==========================================
        // STATUS MANAGEMENT SWITCHES
        // ==========================================
        public static void ActivateUser(int userId)
        {
            string query = "UPDATE Users SET IsActive = 1 WHERE UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userId) };
            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static void DeactivateUser(int userId)
        {
            string query = "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userId) };
            DatabaseHelper.Instance.Update(query, parameters);
        }

        // ==========================================
        // ADMIN PANELS
        // ==========================================
        public static DataTable GetAdmins()
        {
            string query = "SELECT * FROM vw_users WHERE RoleName = 'Admin' ORDER BY UserID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalSuperAdmins()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'SuperAdmin';";
            int count = DatabaseHelper.Instance.ExecuteScalar(query, null);
            return count != -1 ? count : 0;
        }

        // ==========================================
        // ADMIN HOME PANEL
        // ==========================================
        public static DataTable GetUsers()
        {
            string query = "SELECT * FROM vw_users ORDER BY UserID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        // ==========================================
        // ACCOUNT SETTINGS CONTEXT RESOLVERS
        // ==========================================
        public static bool IsUserStudent(int userID)
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE UserID = @UserID AND RoleName = 'Student';";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userID) };

            int count = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return count > 0;
        }
    }
}