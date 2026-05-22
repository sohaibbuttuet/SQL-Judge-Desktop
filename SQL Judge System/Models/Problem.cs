using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Problem : AuditableEntity
    {
        private int problemID;
        private string title;
        private string description;
        private int points;
        private bool isActive;

        // Display fields (from JOIN)
        public string CreatedByName { get; set; }
        public string UpdatedByName { get; set; }

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
            Points = 10;
            IsActive = true;
        }

        // Constructor For Creating New Problem (without ID, CreatedBy)
        public Problem(string title, string description, ProblemDifficulty difficulty, int points, int createdBy)
        {
            Title = title;
            Description = description;
            ProblemDifficulty = difficulty;
            Points = points;

            IsActive = true;

            MarkCreated(createdBy);
        }

        // Constructor For Updating Existing Problem (with ID, UpdatedBy)
        public Problem(int problemID, string title, string description, ProblemDifficulty difficulty, int points, int updatedBy)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            ProblemDifficulty = difficulty;
            Points = points;

            MarkUpdated(updatedBy);
        }

        // Full Constructer For Database Load
        public Problem(int problemID, string title, string description, ProblemDifficulty difficulty, int points, bool isActive, int createdBy, DateTime createdAt, int updatedBy, DateTime updatedAt)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            ProblemDifficulty = difficulty;
            Points = points;
            IsActive = isActive;

            LoadAuditData(createdBy, createdAt, updatedBy, updatedAt);
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
    }
}
