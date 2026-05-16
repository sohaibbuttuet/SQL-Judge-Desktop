using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class UserBL
    {
        // --- For Auth Form ---
        public static bool IsUserAdmin(int userId)
        {
            return UserDL.IsUserAdmin(userId);
        }
        public static bool IsUserSuperAdmin(int userId)
        {
            return UserDL.IsUserSuperAdmin(userId);
        }
        public static void SignUp(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }
            if(!user.Email.Contains("@") || !user.Email.Contains("."))
            {
                throw new ArgumentException("Invalid email format.", nameof(user.Email));
            }
            if (UserDL.IsEmailRegistered(user.Email))
            {
                throw new InvalidOperationException("Email is already registered.");
            }
            user.UserID = UserDL.SignUp(user);
        }
        public static bool SignIn(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }
            if (!user.Email.Contains("@") || !user.Email.Contains("."))
            {
                throw new ArgumentException("Invalid email format.", nameof(user.Email));
            }
            if (!UserDL.ValidateUserCredentials(user))
            {
                throw new InvalidOperationException("Invalid email or password.");
            }

            user.UserID = UserDL.GetUserIdByCredentials(user.Email, user.Password);
            return true;
        }

        public static User GetUserById(int userId)
        {
            if (userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a non-negative integer.");
            }
            User user = UserDL.GetUserByID(userId);
            if (user == null)
            {
                throw new InvalidOperationException("User not found.");
            }
            return user;
        }

        // Students in AdminDashboard
        public static void ActivateUser(int userId)
        {
            if (userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a non-negative integer.");
            }

            if (!UserDL.IsUserExists(userId))
            {
                throw new InvalidOperationException("User does not exist.");
            }

            UserDL.ActivateUser(userId);
        }
        public static void DeactivateUser(int userId)
        {
            if (userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a non-negative integer.");
            }

            if (!UserDL.IsUserExists(userId))
            {
                throw new InvalidOperationException("User does not exist.");
            }

            UserDL.DeactivateUser(userId);
        }

        // Admins in AdminDashboard
        public static int TotalAdmins()
        {
            return UserDL.TotalAdmins();
        }
        public static int TotalSuperAdmins()
        {
            return UserDL.TotalSuperAdmins();
        }
        public static int ActiveAdmins()
        {
            return UserDL.ActiveAdmins();
        }
        public static int InactiveAdmins()
        {
            return UserDL.InactiveAdmins();
        }

        public static int TotalUsers()
        {
            return UserDL.TotalUsers();
        }
        public static int ActiveUsers()
        {
            return UserDL.ActiveUsers();
        }
        public static int InactiveUsers()
        {
            return UserDL.InactiveUsers();
        }
        public static DataTable GetAdminList()
        {
            return UserDL.GetAdminList();
        }
        public static DataTable GetUsers()
        {
            return UserDL.GetUsers();
        }
    }
}
