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
        public int ScoreEarned { get; set; } = 0;

        public SubmissionResult(int resultID, int submissionID, int testCaseID, string actualOutput, bool isPassed, int scoreEarned)
        {
            ResultID = resultID;
            SubmissionID = submissionID;
            TestCaseID = testCaseID;
            ActualOutput = actualOutput;
            IsPassed = isPassed;
            ScoreEarned = scoreEarned;
        }

        // Helper read-only property — useful for showing a tick/cross icon in UI
        public string PassedLabel => IsPassed ? "Passed" : "Failed";
    }
}
