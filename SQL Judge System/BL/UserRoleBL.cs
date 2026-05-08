using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.BL
{
    internal class UserRoleBL
    {
        public static void AssignRoleToUser(UserRole u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u), "UserRole cannot be null.");
            }
            UserRoleDL.AssignRoleToUser(u);
        }
    }
}
