using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class UserRole
    {
        private int UserID;
        private int RoleID;

        public int GetUserID() { return UserID; }
        public int GetRoleID() { return RoleID; }

        public UserRole() { }
        public UserRole(int userID, int roleID)
        {
            UserID = userID;
            RoleID = roleID;
        }
    }
}
