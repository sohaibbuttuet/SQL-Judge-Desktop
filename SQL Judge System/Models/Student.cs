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
        private int totalScore;
        private int problemsSolved;

        // ===================================
        // Aggregation: (1-to-1 relationship)
        // ===================================
        private SkillLevel skillLevel; 

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
            private set
            {
                if (value <= 0)
                    throw new Exception("Invalid Skill Level ID.");

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
        // Aggregation Property
        // =========================
        public SkillLevel SkillLevel
        {
            get { return skillLevel; }
            set
            {
                if(value == null)
                    throw new Exception("Skill level cannot be null.");

                skillLevel = value;           
            }
        }

        // =========================
        // Constructers
        // =========================
        public Student() { }
        public Student(int userID, string registrationNumber, SkillLevel skillLevel)
        {
            UserID = userID;
            RegistrationNumber = registrationNumber;
            SkillLevel = skillLevel;
            TotalScore = 0;
            ProblemsSolved = 0;
        }
        public Student(int studentID, int userID, string registrationNumber, int totalScore, int problemsSolved, SkillLevel skillLevel)
        {
            StudentID = studentID;
            UserID = userID;
            RegistrationNumber = registrationNumber;            
            TotalScore = totalScore;
            ProblemsSolved = problemsSolved;
            SkillLevel = skillLevel;
        }
    }
}
