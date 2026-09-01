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
        private bool isPassed;
        private string errorMessage;

        public int ResultID
        {
            get { return resultID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Result ID.");

                resultID = value;
            }
        }
        public int SubmissionID
        {
            get { return submissionID; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Invalid Submission ID.");

                submissionID = value;
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
            ErrorMessage = "";
        }
        public SubmissionResult(int submissionID, bool isPassed, string errorMessage)
        {
            SubmissionID = submissionID;
            IsPassed = isPassed;
            ErrorMessage = errorMessage ?? "";
        }
    }
}
