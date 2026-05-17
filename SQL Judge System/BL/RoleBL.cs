using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.LookupDL;

namespace SQL_Judge_System.BL
{
    internal class RoleBL
    {
        public static int GetStudentRoleID()
        {
            return RoleDL.GetStudentRoleID();
        }
        public static int GetAdminRoleID()
        {
            return RoleDL.GetAdminRoleID();
        }
    }
}
