using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class User
    {
        private int userID;
        private string fullName;
        private string email;
        private string password;
        private bool isActive;
        private DateTime createdAt;
        private DateTime updatedAt;

        public int UserID
        {
            get { return userID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid User ID.");

                userID = value;
            }
        }
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Full name cannot be empty.");

                fullName = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@") || !value.Contains("."))
                    throw new Exception("Invalid email format.");

                email = value;
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    throw new Exception("Password too weak.");

                password = value;
            }
        }
        public bool IsActive
        {
            get { return isActive; }
            private set { isActive = value; }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            private set { createdAt = value; }
        }
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            private set { updatedAt = value; }
        }

        // Default Constructer
        public User()
        {
            IsActive = true;
        }

        // For Add User
        public User(string fullName, string email, string password)
        {
            FullName = fullName;  
            Email = email;
            Password = password;

            IsActive = true;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        // For Update User
        public User(int userId, string fullName, string email, string password)
        {
            UserID = userId;
            FullName = fullName;
            Email = email;
            Password = password;

            UpdatedAt = DateTime.Now;
            IsActive = true;
        }

        // Full Constructer for DB load
        public User(int userId, string fullName, string email, string password, bool isActive, DateTime createdAt, DateTime updatedAt)
        {
            UserID = userId;
            FullName = fullName;
            Email = email;
            Password = password;
            IsActive = isActive;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
    }
}
