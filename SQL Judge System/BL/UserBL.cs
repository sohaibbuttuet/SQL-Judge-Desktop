using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void UpdateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("user can not null");
            }
            if (!user.Email.Contains("@") || !user.Email.Contains("."))
            {
                throw new ArgumentException("Invalid email format.", nameof(user.Email));
            }
            if (UserDL.IsEmailRegistered(user.UserID, user.Email))
            {
                MessageBox.Show("Email already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UserDL.UpdateUser(user);
        }
        public static User SignIn(string email, string password)
        {
            User user = UserDL.SignIn(email, password);

            if (user == null)
                throw new InvalidOperationException("Invalid email or password.");

            return user;
        }

        // Admin Home Panel
        public static DataTable GetUsers()
        {
            return UserDL.GetUsers();
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

        // Super Admin panel
        public static DataTable GetAdminList()
        {
            return UserDL.GetAdminList();
        }
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

        // Students panel and SuperAdmin Panel
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

        // AdminPopup Form       
        public static User GetUserById(int userId)
        {
            if (userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a non-negative integer.");
            }

            return UserDL.GetUserByID(userId);
        }

        // User Lookup Table (Roles)
        public static int GetStudentRoleID()
        {
            return RoleDL.GetStudentRoleID();
        }
        public static int GetAdminRoleID()
        {
            return RoleDL.GetAdminRoleID();
        }

        // User Junction Table (UserRole)
        public static void AssignRoleToUser(UserRole u)
        {
            if (u == null)
            {
                throw new ArgumentNullException(nameof(u), "UserRole cannot be null.");
            }
            UserRoleDL.AssignRoleToUser(u);
        }
    }
}
