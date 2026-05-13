using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.LookupDL
{
    internal class RoleDL
    {
        public static int GetStudentRoleID()
        {
            string query = "SELECT RoleID FROM Roles WHERE RoleName = 'Student';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}
