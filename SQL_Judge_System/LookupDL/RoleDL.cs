using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.LookupDL
{
    internal class RoleDL
    {
        public static int GetStudentRoleID()
        {
            string query = "SELECT RoleID FROM Roles WHERE RoleName = 'Student';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int GetAdminRoleID()
        {
            string query = "SELECT RoleID FROM Roles WHERE RoleName = 'Admin';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
    }
}
