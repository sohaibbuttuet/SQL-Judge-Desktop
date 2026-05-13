using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SubmissionResult
    {
        public int ResultID { get; set; }
        public int SubmissionID { get; set; }   // FK → Submissions
        public int TestCaseID { get; set; }   // FK → TestCases
        public string ActualOutput { get; set; }   // What the student's query actually returned
        public bool IsPassed { get; set; } = false;
        public string ErrorMessage { get; set; } = "";   // Optional: Store error message if the query execution failed


        public SubmissionResult() { }
        public SubmissionResult(int submissionID, int testCaseID, string actualOutput, bool isPassed, string errorMessage)
        {
            SubmissionID = submissionID;
            TestCaseID = testCaseID;
            ActualOutput = actualOutput;
            IsPassed = isPassed;
            ErrorMessage = errorMessage;
        }
    }
}
