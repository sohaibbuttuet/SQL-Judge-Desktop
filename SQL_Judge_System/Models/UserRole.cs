using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class UserRole
    {
        private int userID;
        private int roleID;

        public int UserID
        {
            get { return userID; }
            set
            {
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException("Invalid UserID");
                userID = value;
            }
        }
        public int RoleID
        {
            get { return roleID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Invalid Role ID"); 
                roleID = value;
            }
        }

        public UserRole() { }
        public UserRole(int userID, int roleID)
        {
            UserID = userID;
            RoleID = roleID;
        }
    }
}
