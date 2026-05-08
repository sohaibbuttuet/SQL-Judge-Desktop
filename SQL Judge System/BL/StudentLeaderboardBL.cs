using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class StudentLeaderboardBL
    {
        public static DataTable GetLeaderboard()
        {
            return DL.StudentLeaderboardDL.GetLeaderboard();
        }
        public static int GetRank(int studentId)
        {
            if(studentId <= 0)
            {
                throw new ArgumentException("Student ID must be a positive integer.", nameof(studentId));
            }
            return DL.StudentLeaderboardDL.GetRank(studentId);
        }
        public static int GetTotalScore(int studentId)
        {
            if (studentId <= 0)
            {
                throw new ArgumentException("Student ID must be a positive integer.", nameof(studentId));
            }
            return DL.StudentLeaderboardDL.GetTotalScore(studentId);
        }
        public static int GetSolvedProblemsCount(int studentId)
        {
            if (studentId <= 0)
            {
                throw new ArgumentException("Student ID must be a positive integer.", nameof(studentId));
            }
            return DL.StudentLeaderboardDL.GetSolvedProblemsCount(studentId);
        }
        public static string GetSkillLevel(int studentId)
        {
            if (studentId <= 0)
            {
                throw new ArgumentException("Student ID must be a positive integer.", nameof(studentId));
            }
            return DL.StudentLeaderboardDL.GetSkillLevel(studentId);
        }
    }
}
