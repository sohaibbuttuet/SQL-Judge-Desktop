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
            string query = $"INSERT INTO UserRoles (UserID, RoleID) VALUES ({u.UserID}, {u.RoleID});";
            DatabaseHelper.Instance.Update(query);
        }
        public static void ChangeUserRole(UserRole u)
        {
            string query = $"UPDATE UserRoles SET RoleID = {u.RoleID} WHERE UserID = {u.UserID};";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
