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


        // =======================================
        // Composition (many-to-many relationship) 
        // =======================================
        private List<Role> roles = new List<Role>();

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

        // =========================
        // Safe Composition Exposure
        // =========================
        public IReadOnlyList<Role> Roles
        {
            get { return roles.AsReadOnly(); }
        }


        // =========================
        // Constructers
        // =========================
        public User()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }

        // For Add User
        public User(string fullName, string email, string password)
        {
            FullName = fullName;  
            Email = email;
            Password = password;

            IsActive = true;
            CreatedAt = DateTime.Now;
        }

        // For Update User
        public User(int userId, string fullName, string email, string password)
        {
            UserID = userId;
            FullName = fullName;
            Email = email;
            Password = password;

            IsActive = true;
        }

        // Full Constructer for DB load
        public User(int userId, string fullName, string email, string password, bool isActive, DateTime createdAt, DateTime UpdatedAt)
        {
            UserID = userId;
            FullName = fullName;
            Email = email;
            Password = password;
            IsActive = isActive;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        // =========================
        // Composition Management
        // =========================
        public void AddRole(Role role)
        {
            if (role == null)
                throw new Exception("Role cannot be null.");

            roles.Add(role);
        }
        public void RemoveRole(Role role)
        {
            if (role == null)
                throw new Exception("Role cannot be null.");

            roles.Remove(role);
        }
        public void ClearRoles()
        {
            roles.Clear();
        }
    }
}
