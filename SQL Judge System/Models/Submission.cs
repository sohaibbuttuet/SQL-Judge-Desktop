using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Submission
    {
        public int SubmissionID { get; set; }
        public int StudentID { get; set; }   // FK → Students
        public int ProblemID { get; set; }   // FK → Problems
        public string QueryText { get; set; }   // The SQL the student wrote
        public int StatusID { get; set; }   // FK → SubmissionStatuses
        public int AttemptNumber { get; set; } // The attempt number for this problem by the student
        public int TotalScore { get; set; } 
        public DateTime SubmittedAt { get; set; } 

        public Submission()
        {
            SubmittedAt = DateTime.Now;
            AttemptNumber = 1;
            TotalScore = 0;
        }
        public Submission(int studentID, int problemID, string queryText, int statusID, int attemptNumber, int totalScore)
        {
            StudentID = studentID;
            ProblemID = problemID;
            QueryText = queryText;
            StatusID = statusID;
            AttemptNumber = attemptNumber;
            TotalScore = totalScore;
            SubmittedAt = DateTime.Now;
        }
    }
}
