using MidDb26_2025CS259;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using System.Data;

namespace SQL_Judge_System.DL
{
    internal class RoleDL
    {
        public static List<Role> GetAllRoles()
        {
            string query = "SELECT * FROM Roles";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Role> roles = new List<Role>();
            foreach (DataRow row in dt.Rows)
            {
                roles.Add(MapRowToRole(row));
            }

            return roles;
        }
        public static Role GetRoleById(int roleId)
        {
            string query = $"SELECT * FROM Roles WHERE RoleID = {roleId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count < 0)
                return null;

            return MapRowToRole(dt.Rows[0]);

        }

        // Helper method to map a DataRow to a Role object
        private static Role MapRowToRole(DataRow row)
        {
            return new Role
            {
                RoleID = Convert.ToInt32(row["RoleID"]),
                RoleName = row["RoleName"].ToString()
            };
        }
    }
}
