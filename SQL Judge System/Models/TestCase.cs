using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class TestCase : AuditableEntity
    {
        private int testCaseID;
        private string testCaseName;
        private int problemID;
        private string setupSQL;
        private string solutionQuery;
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

            IsActive = true;

            MarkCreated(createdBy);
        }

        // Constructor For Updating Existing Test Case (with ID, UpdatedBy)
        public TestCase(int testCaseID, string testCaseName, int problemID, string setupSQL, string solutionQuery, int updatedBy)
        {
            TestCaseID = testCaseID;
            TestCaseName = testCaseName;
            ProblemID = problemID;
            SetupSQL = setupSQL;
            SolutionQuery = solutionQuery;

            IsActive = true;

            MarkUpdated(updatedBy);
        }
    }
}

