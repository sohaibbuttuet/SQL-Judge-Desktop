using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Student
    {
        public int StudentID { get; set; }
        public int UserID { get; set; }   // FK → Users
        public string RegistrationNumber { get; set; }   // must be unique
        public int SkillLevelID { get; set; }   // FK → SkillLevels
        public int TotalScore { get; set; } = 0;
        public int ProblemsSolved { get; set; } = 0;

        public Student() { }
        public Student(int userID, string registrationNumber, int skillLevelID)
        {
            UserID = userID;
            RegistrationNumber = registrationNumber;
            SkillLevelID = skillLevelID;
        }
        public Student(int studentID, int userID, string fullName, string registrationNumber, int skillLevelID, int totalScore, int problemsSolved)
        {
            StudentID = studentID;
            UserID = userID;
            RegistrationNumber = registrationNumber;
            SkillLevelID = skillLevelID;
            TotalScore = totalScore;
            ProblemsSolved = problemsSolved;
        }
    }
}
