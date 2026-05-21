using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class TestCase
    {
        private int testCaseID;
        private string testCaseName;
        private int problemID;
        private string setupSQL;
        private string solutionQuery;
        private int createdBy;
        private DateTime createdAt;
        private int updatedBy;
        private DateTime updatedAt;
        private bool isActive;


        public int TestCaseID
        {
            get { return testCaseID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid TestCase ID.");

                testCaseID = value;
            }
        }
        public string TestCaseName
        {
            get { return testCaseName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Test case name cannot be empty.");

                testCaseName = value;
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
        public string SetupSQL
        {
            get { return setupSQL; }
            set
            {
                setupSQL = value ?? "";
            }
        }
        public string SolutionQuery
        {
            get { return solutionQuery; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Solution query cannot be empty.");

                solutionQuery = value;
            }
        }
        public int CreatedBy
        {
            get { return createdBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid creator ID.");
                createdBy = value;
            }
        }
        public DateTime CreatedAt
        {
            get { return createdAt; }
            private set
            {
                if (value > DateTime.Now)
                    throw new Exception("Creation date cannot be in the future.");
                createdAt = value;
            }
        }
        public int UpdatedBy
        {
            get { return updatedBy; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid updater ID.");
                updatedBy = value;
            }
        }
        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            private set
            {
                if (value > DateTime.Now)
                    throw new Exception("Update date cannot be in the future.");
                updatedAt = value;
            }
        }
        public bool IsActive
        {
            get { return isActive; }
            private set { isActive = value; }
        }

        // Default Constructor
        public TestCase()
        {
            IsActive = true;
        }

        // Constructor For Creating New Test Case (without ID, CreatedBy)
        public TestCase(string testCaseName, int problemID, string setupSQL, string solutionQuery, int createdBy)
        {
            TestCaseName = testCaseName;
            ProblemID = problemID;
            SetupSQL = setupSQL;
            SolutionQuery = solutionQuery;
            CreatedBy = createdBy;

            CreatedAt = DateTime.Now;
            IsActive = true;
        }

        // Constructor For Updating Existing Test Case (with ID, UpdatedBy)
        public TestCase(int testCaseID, string testCaseName, int problemID, string setupSQL, string solutionQuery, int updatedBy)
        {
            TestCaseID = testCaseID;
            TestCaseName = testCaseName;
            ProblemID = problemID;
            SetupSQL = setupSQL;
            SolutionQuery = solutionQuery;
            UpdatedBy = updatedBy;

            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}

