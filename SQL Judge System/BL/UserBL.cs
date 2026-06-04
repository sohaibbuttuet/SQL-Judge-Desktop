using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace SQL_Judge_System.BL
{
    internal class UserBL
    {
        // ==========================================
        // AUTHENTICATION & ACCESS CONTROL HANDLERS
        // ==========================================
        public static bool IsUserSuperAdmin(int userId)
        {
            if (userId <= 0) return false;
            return UserDL.IsUserSuperAdmin(userId);
        }
        public static void SignUp(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            ValidateEmail(user.Email); // internally throww exceptions

            if (UserDL.IsEmailRegistered(user.Email))
                throw new InvalidOperationException("This email address is already registered in the system.");

            user.UserID = UserDL.SignUp(user);
        }
        public static void UpdateUser(User user)
        {
            ValidateUser(user);
            UserDL.UpdateUser(user);
        }
        public static void UpdateProfile(User user)
        {
            ValidateUser(user);
            UserDL.UpdateProfile(user);
        }        
        public static void ChangePassword(int userID, string password)
        {
            if (userID <= 0)
                throw new ArgumentException("Invalid User ID mapping for operation.", nameof(userID));
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password content cannot be empty.");

            UserDL.ChangePassword(userID, password);
        }
        public static bool VerifyPassword(int userID, string password)
        {
            if (userID <= 0)
                throw new ArgumentException("Invalid User ID mapping for operation.", nameof(userID));

            return UserDL.VerifyPassword(userID, password);
        }
        public static User SignIn(string email, string password)
        {
            ValidateEmail(email); // internally throww exceptions
            return UserDL.SignIn(email, password);
        }

        // ==========================================
        // VALIDATION UTILITIES (PRIVATE)
        // ==========================================
        private static void ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException(nameof(email), "Email cannot be null or empty.");

            try
            {
                MailAddress m = new MailAddress(email);
            }
            catch (FormatException)
            {
                throw new ArgumentException("The provided email address format is invalid.");
            }
        }
        private static void ValidateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user), "User cannot be null.");

            ValidateEmail(user.Email); // internally throww exceptions

            if (UserDL.IsEmailRegistered(user.UserID, user.Email))
                throw new ArgumentException("This email address is already tied to another registered account.");
        }

        // ==========================================
        // ADMIN MANAGEMENT PANEL VIEW DATA
        // ==========================================
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

        // ==========================================
        // SUPER-ADMIN MANAGEMENT ROLES
        // ==========================================
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

        // ==========================================
        // ACTIVATION CONTROL SWITCHES
        // ==========================================
        public static void ActivateUser(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a positive integer.");

            if (!UserDL.IsUserExists(userId))
                throw new InvalidOperationException("The requested user record does not exist.");

            UserDL.ActivateUser(userId);
        }
        public static void DeactivateUser(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a positive integer.");

            if (!UserDL.IsUserExists(userId))
                throw new InvalidOperationException("The requested user record does not exist.");

            UserDL.DeactivateUser(userId);
        }
        public static User GetUserById(int userId)
        {
            if (userId <= 0)
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID must be a positive integer.");

            return UserDL.GetUserByID(userId);
        }

        // ==========================================
        // ROLE ACCESS MANAGEMENT
        // ==========================================
        public static int GetStudentRoleID()
        {
            return RoleDL.GetStudentRoleID();
        }
        public static int GetAdminRoleID()
        {
            return RoleDL.GetAdminRoleID();
        }
        public static void AssignRoleToUser(UserRole u)
        {
            if (u == null)
                throw new ArgumentNullException(nameof(u), "UserRole configuration parameters cannot be null.");

            UserRoleDL.AssignRoleToUser(u);
        }

        // Setting Form
        public static bool IsUserStudent(int userID)
        {
            if (userID <= 0)
                throw new ArgumentOutOfRangeException(nameof(userID), "Invalid target User ID metadata context provided.");

            return UserDL.IsUserStudent(userID);
        }
    }
}
