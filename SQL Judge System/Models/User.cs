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
        public string Email { get; set; }
        public string Password { get; set; }   
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public User()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
        public User(string email, string password)
        {
            Email = email;
            Password = password;
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}
