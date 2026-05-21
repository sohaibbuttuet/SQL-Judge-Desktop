using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Role
    {
        private int roleId;
        private string roleName;

        public int RoleId
        {
            get { return roleId; }
            set
            { 
                if(value <= 0) 
                    throw new ArgumentOutOfRangeException("value");
                roleId = value; 
            }
        }
        public string RoleName
        {
            get { return roleName; }
            set 
            {
                if(string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException("value"); 
                roleName = value; 
            }
        } 
        public Role() { }
        public Role(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
    }
}
