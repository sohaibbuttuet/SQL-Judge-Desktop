using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class TestCase
    {
        public int TestCaseID { get; set; }
        public int ProblemID { get; set; }   // FK → Problems
        public string SetupSQL { get; set; }   // SQL that sets up the test environment
        public string ExpectedOutput { get; set; }   // Correct result the student must match
        public bool IsActive { get; set; } = true;  // Indicates if the test case is active

        public TestCase() { }
        public TestCase(int testCaseID, int problemID, string setupSQL, string expectedOutput)
        {
            TestCaseID = testCaseID;
            ProblemID = problemID;
            SetupSQL = setupSQL;
            ExpectedOutput = expectedOutput;
        }
    }
}
