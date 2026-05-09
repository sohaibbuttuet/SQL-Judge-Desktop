using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.BL
{
    internal class UserBL
    {
        // --- For Auth Form ---
        public static bool IsUserAdmin(int userId)
        {
            return UserDL.IsUserAdmin(userId);
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
        
    }
}
