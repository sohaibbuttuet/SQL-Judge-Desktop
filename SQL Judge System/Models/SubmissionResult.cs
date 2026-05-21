using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SubmissionResult
    {
        private int resultID;
        private int submissionID;
        private int testCaseID;
        private string actualOutput;
        private bool isPassed;
        private string errorMessage;

        public int ResultID
        {
            get { return resultID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Result ID.");

                resultID = value;
            }
        }
        public int SubmissionID
        {
            get { return submissionID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Submission ID.");

                submissionID = value;
            }
        }
        public int TestCaseID
        {
            get { return testCaseID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Test Case ID.");

                testCaseID = value;
            }
        }
        public string ActualOutput
        {
            get { return actualOutput; }
            set
            {
                actualOutput = value ?? "";
            }
        }
        public bool IsPassed
        {
            get { return isPassed; }
            set { isPassed = value; }
        }
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value ?? "";
            }
        }

        public SubmissionResult()
        {
            IsPassed = false;
            ActualOutput = "";
            ErrorMessage = "";
        }
        public SubmissionResult(int submissionID, int testCaseID, string actualOutput, bool isPassed, string errorMessage)
        {
            SubmissionID = submissionID;
            TestCaseID = testCaseID;
            ActualOutput = actualOutput ?? "";
            IsPassed = isPassed;
            ErrorMessage = errorMessage ?? "";
        }
    }
}
