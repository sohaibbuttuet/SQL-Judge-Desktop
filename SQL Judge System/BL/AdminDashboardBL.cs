using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.BL
{
    internal class AdminDashboardBL
    {
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

        public static int TotalAdmins()
        {
            return UserDL.TotalAdmins();
        }
        public static int ActiveAdmins()
        {
            return UserDL.ActiveAdmins();
        }
        public static int InactiveAdmins()
        {
            return UserDL.InactiveAdmins();
        }

        public static int TotalContests()
        {
            return ContestDL.TotalContests();
        }
        public static int TotalProblems()
        {
            return ProblemDL.TotalProblems();
        }
    }
}
