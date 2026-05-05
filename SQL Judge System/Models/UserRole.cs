using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class UserRole
    {
        public int UserID { get; set; }
        public int RoleID { get; set; } 

        public UserRole(int userID, int roleID)
        {
            UserID = userID;
            RoleID = roleID;
        }
    }
}
