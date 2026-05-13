using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public User()
        {
        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User(string fullName, string email, string password)
        {
            FullName = fullName;  
            Email = email;
            Password = password;
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}
