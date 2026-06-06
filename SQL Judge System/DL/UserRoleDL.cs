using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class UserRoleDL
    {
        public static void AssignRoleToUser(UserRole u)
        {
            string query = "INSERT INTO UserRoles (UserID, RoleID) VALUES (@UserID, @RoleID);";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@UserID", u.UserID),
                new MySqlParameter("@RoleID", u.RoleID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static string GetRoleNameByUserID(int userID)
        {
            string query = "SELECT r.RoleName FROM Roles r " +
                           "JOIN UserRoles ur ON r.RoleID = ur.RoleID " +
                           "WHERE ur.UserID = @UserID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@UserID", userID)
            };

            return DatabaseHelper.Instance.ExecuteScalarObject(query, parameters).ToString();
        }
    }
}
