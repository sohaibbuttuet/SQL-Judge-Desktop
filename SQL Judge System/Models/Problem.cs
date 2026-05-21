using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Problem
    {
        private int problemID;
        private string title;
        private string description;
        private int points;
        private int createdBy;
        private DateTime createdAt;
        private int updatedBy;
        private DateTime updatedAt;
        private bool isActive;

        // ====================================
        // Composition (1-to-many relationship) 
        // ====================================
        private List<TestCase> testCases = new List<TestCase>();
        private List<ProblemTag> problemTags = new List<ProblemTag>();

        // ===================================
        // Aggregation: (1-to-1 relationship)
        // ===================================
        private ProblemDifficulty problemDifficulty;

        // =========================
        // Properties
        // =========================
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
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Title cannot be empty.");

                title = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Description cannot be empty.");

                description = value;
            }
        }
        public int Points
        {
            get { return points; }
            set
            {
                if (value <= 0)
                    throw new Exception("Points must be greater than 0.");

                points = value;
            }
        }
        public int CreatedBy
        {
            get { return createdBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid CreatedBy ID.");

                createdBy = value;
            }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            private set { createdAt = value; }
        }
        public int UpdatedBy
        {
            get { return updatedBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid UpdatedBy ID.");

                updatedBy = value;
            }
        }
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            private set { updatedAt = value; }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        // =========================
        // Safe Composition Exposure
        // =========================
        public IReadOnlyList<TestCase> TestCases
        {
            get { return testCases.AsReadOnly(); }
        }
        public IReadOnlyList<ProblemTag> ProblemTags
        {
            get { return problemTags.AsReadOnly(); }
        }

        // =========================
        // Aggregation Property
        // =========================
        public ProblemDifficulty ProblemDifficulty
        {
            get { return problemDifficulty; }
            set
            {
                if (value == null)
                    throw new Exception("Difficulty cannot be null.");

                problemDifficulty = value;
            }
        }

        // =========================
        // Constructers
        // =========================
        public Problem()
        {
            CreatedAt = DateTime.Now;
            Points = 10;
            IsActive = true;
        }
        public Problem(string title, string description, ProblemDifficulty difficulty, int createdBy, int points)
        {
            Title = title;
            Description = description;
            ProblemDifficulty = difficulty;
            CreatedBy = createdBy;
            Points = points;

            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
        public Problem(int problemID, string title, string description, ProblemDifficulty difficulty, int createdBy, int updatedBy, int points, DateTime createdAt, DateTime updatedAt, bool isActive)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            ProblemDifficulty = difficulty;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            Points = points;

            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            IsActive = isActive;
        }

        // =========================
        // Composition Management
        // =========================
        public void AddTestCase(TestCase testCase)
        {
            if (testCase == null)
                throw new Exception("Test case cannot be null.");

            testCases.Add(testCase);
        }
        public void RemoveTestCase(TestCase testCase)
        {
            if (testCase == null)
                throw new Exception("Test case cannot be null.");

            testCases.Remove(testCase);
        }

        public void AddTag(ProblemTag tag)
        {
            if (tag == null)
                throw new Exception("Tag cannot be null.");

            problemTags.Add(tag);
        }
        public void RemoveTag(ProblemTag tag)
        {
            if (tag == null)
                throw new Exception("Tag cannot be null.");

            problemTags.Remove(tag);
        }

        public void ClearTestCases()
        {
            testCases.Clear();
        }
        public void ClearTags()
        {
            problemTags.Clear();
        }


        // =========================
        // Audit Management
        // =========================
        public void MarkUpdated(int updatedBy)
        {
            UpdatedBy = updatedBy;
            UpdatedAt = DateTime.Now;
        }
    }
}
