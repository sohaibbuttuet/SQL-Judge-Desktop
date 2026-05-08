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


        public SubmissionResult() { }
        public SubmissionResult(int resultID, int submissionID, int testCaseID, string actualOutput, bool isPassed)
        {
            ResultID = resultID;
            SubmissionID = submissionID;
            TestCaseID = testCaseID;
            ActualOutput = actualOutput;
            IsPassed = isPassed;
        }
    }
}
