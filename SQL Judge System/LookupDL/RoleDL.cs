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
        public static DataTable GetAllRoles()
        {
            string query = "SELECT RoleID, RoleName FROM Roles;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
