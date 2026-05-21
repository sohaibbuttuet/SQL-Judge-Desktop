using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Submission
    {
        private int submissionID;
        private int studentID;
        private int problemID;
        private string queryText;
        private int attemptNumber;
        private int totalScore;
        private DateTime submittedAt;

        // =====================================
        // Composition: (1-to-many relationship)
        // =====================================
        private List<SubmissionResult> submissionResults = new List<SubmissionResult>;

        // =====================================
        // Aggregation: (1-to-1 relationship)
        // =====================================
        private SubmissionStatus status;

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
        public int ProblemID
        {
            get { return problemID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Problem ID.");

                problemID = value;
            }
        }
        public string QueryText
        {
            get { return queryText; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Query cannot be empty.");

                queryText = value;
            }
        }
        public int AttemptNumber
        {
            get { return attemptNumber; }
            set
            {
                if (value <= 0)
                    throw new Exception("Attempt number must be at least 1.");

                attemptNumber = value;
            }
        }
        public int TotalScore
        {
            get { return totalScore; }
            set
            {
                if (value < 0)
                    throw new Exception("Score cannot be negative.");

                totalScore = value;
            }
        }
        public DateTime SubmittedAt
        {
            get { return submittedAt; }
            private set { submittedAt = value; }
        }

        // =========================
        // Aggregation Property
        // =========================
        public SubmissionStatus Status
        {
            get { return status; }
            set
            {
                if (value == null)
                    throw new Exception("Submission Status can not be null");

                status = value;
            }
        }

        // =========================
        // Safe Composition Exposure
        // =========================
        public IReadOnlyList<SubmissionResult> SubmissionResults
        {
            get { return submissionResults.AsReadOnly(); }
        }


        // =========================
        // Constructers
        // =========================
        public Submission()
        {
            SubmittedAt = DateTime.Now;
            AttemptNumber = 1;
            TotalScore = 0;
        }
        public Submission(int studentID, int problemID, string queryText, SubmissionStatus status, int attemptNumber, int totalScore)
        {
            StudentID = studentID;
            ProblemID = problemID;
            QueryText = queryText;
            Status = status;
            AttemptNumber = attemptNumber;
            TotalScore = totalScore;

            SubmittedAt = DateTime.Now;
        }

        // =========================
        // Composition Management
        // =========================
        public void AddResult(SubmissionResult result)
        {
            if (result == null)
                throw new Exception("Submission result cannot be null.");

            submissionResults.Add(result);
        }
        public void RemoveResult(SubmissionResult result)
        {
            if (result == null)
                throw new Exception("Submission result cannot be null.");

            submissionResults.Remove(result);
        }
        public void ClearResult()
        {
           submissionResults.Clear();
        }

        // =========================
        // Business Methods
        // =========================
        public void AddScore(int score)
        {
            if (score < 0)
                throw new Exception("Score cannot be negative.");

            TotalScore += score;
        }
        public void IncrementAttempt()
        {
            AttemptNumber++;
        }
        public void UpdateStatus(SubmissionStatus newStatus)
        {
            Status = newStatus;
        }

    }
}
