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
        public int TotalScore { get; set; } = 0;
        public DateTime SubmittedAt { get; set; } = DateTime.Now;

        public Submission(int submissionID, int studentID, int problemID, string queryText, int statusID, int totalScore, DateTime submittedAt)
        {
            SubmissionID = submissionID;
            StudentID = studentID;
            ProblemID = problemID;
            QueryText = queryText;
            StatusID = statusID;
            TotalScore = totalScore;
            SubmittedAt = submittedAt;
        }
    }
}
