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
    internal class AdminDashboardBL
    {
        // --- STUDENT PANEL ---
        public static DataTable GetStudentsForAdmin()
        {
            return StudentDL.GetStudentsForAdmin();
        }
        public static int TotalStudents()
        {
            return StudentDL.TotalStudents();
        }
        public static int ActiveStudents()
        {
            return StudentDL.ActiveStudents();
        }
        public static int InactiveStudents()
        {
            return StudentDL.InactiveStudents();
        }
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

        // --- ADMIN PANEL ---
        public static int TotalAdmins()
        {
            return UserDL.TotalAdmins();
        }
        public static List<User> GetAdminList()
        {
            return UserDL.GetAdminList();
        }

        // --- CONTESTS PANEL ---
        public static int TotalContests()
        {
            return ContestDL.TotalContests();
        }

        // --- PROBLEMS PANEL ---
        public static DataTable ProblemsList()
        {
            return ProblemDL.ProblemsList();
        }
        public static int TotalProblems()
        {
            return ProblemDL.TotalProblems();
        }        
        public static int ActiveProblems()
        {
            return ProblemDL.ActiveProblems();
        }
        public static int InactiveProblems()
        {
            return ProblemDL.InactiveProblems();
        }
        public static void ActivateProblem(int problemId)
        {
            if (problemId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be a non-negative integer.");
            }
            if (!ProblemDL.IsProblemExists(problemId))
            {
                throw new InvalidOperationException("Problem does not exist.");
            }
            ProblemDL.ActivateProblem(problemId);
        }
        public static void DeactivateProblem(int problemId)
        {
            if (problemId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be a non-negative integer.");
            }
            if (!ProblemDL.IsProblemExists(problemId))
            {
                throw new InvalidOperationException("Problem does not exist.");
            }
            ProblemDL.DeactivateProblem(problemId);
        }
    }
}
