using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Student
    {
        private int studentID;
        private int userID;
        private string registrationNumber;
        private int skillLevelID;
        private int totalScore;
        private int problemsSolved;

        public int StudentID
        {
            get { return studentID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Student ID.");

                studentID = value;
            }
        }
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
        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Registration number cannot be empty.");

                registrationNumber = value;
            }
        }
        public int SkillLevelID
        {
            get { return skillLevelID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Skill Level ID");
                skillLevelID = value;
            }
        }
        public int TotalScore
        {
            get { return totalScore; }
            set
            {
                if (value < 0)
                    throw new Exception("Total score cannot be negative.");

                totalScore = value;
            }
        }
        public int ProblemsSolved
        {
            get { return problemsSolved; }
            set
            {
                if (value < 0)
                    throw new Exception("Problems solved cannot be negative.");

                problemsSolved = value;
            }
        }

        // =========================
        // Constructers
        // =========================
        public Student() { }
        public Student(int userID, string registrationNumber, int skillLevelID)
        {
            UserID = userID;
            RegistrationNumber = registrationNumber;
            SkillLevelID = skillLevelID;
            TotalScore = 0;
            ProblemsSolved = 0;
        }

        // Full Constructer For Database Load
        public Student(int studentID, int userID, string registrationNumber, int totalScore, int problemsSolved, int skillLevelID)
        {
            StudentID = studentID;
            UserID = userID;
            RegistrationNumber = registrationNumber;            
            TotalScore = totalScore;
            ProblemsSolved = problemsSolved;
            SkillLevelID = skillLevelID;
        }
    }
}
