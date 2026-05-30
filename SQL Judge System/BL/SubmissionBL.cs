using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.BL
{
    internal class SubmissionBL
    {
        public static List<SubmissionResult> CreateSubmission(Submission submission)
        {
            if (submission == null)
                throw new ArgumentException("Submission cannot be null.");

            if (submission.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            if (submission.StudentID <= 0)
                throw new ArgumentException("Invalid StudentID.");

            // This will throw an ArgumentException and stop execution if malicious text is found.
            submission.QueryText = QueryRunnerBL.CleanAndValidateQuery(submission.QueryText);

            // Set the accurate attempt number 
            submission.AttemptNumber = SubmissionDL.GetAttempts(submission.StudentID, submission.ProblemID) + 1;

            // 1. Save submission record FIRST to get the Auto-Incremented SubmissionID
            submission.SubmissionID = SubmissionDL.AddSubmission(submission);

            // 2. Evaluate query against all test cases dynamically
            List<SubmissionResult> results = EvaluateQuery(submission.SubmissionID, submission.ProblemID, submission.QueryText);

            // 3. Determine the final aggregate submission status matching your schema lookups
            bool allPassed = results.All(r => r.IsPassed);
            bool hasRuntimeError = results.Any(r => r.ErrorMessage.StartsWith("Runtime SQL Error"));

            if (hasRuntimeError)
            {
                submission.StatusID = SubmissionStatusDL.GetRunTimeError(); // Status 3
                submission.TotalScore = 0;
            }
            else if (allPassed)
            {
                // Double check if they have cleared this problem before
                if (!SubmissionDL.HasAcceptedSubmission(submission.StudentID, submission.ProblemID))
                {
                    submission.StatusID = SubmissionStatusDL.GetAccepted(); // Status 1
                    submission.TotalScore = ProblemBL.GetProblemByID(submission.ProblemID).Points;
                }
                else
                {
                    // Already solved in the past: They get Accepted status but 0 additional points
                    submission.StatusID = SubmissionStatusDL.GetAccepted();
                    submission.TotalScore = 0;
                }
            }
            else
            {
                submission.StatusID = SubmissionStatusDL.GetWrongAnswer(); // Status 2
                submission.TotalScore = 0;
            }

            // 4. Update the saved submission row with the newly calculated status and scores
            SubmissionDL.UpdateSubmission(submission);

            // 5. Save the detailed results breakdown per testcase for academic tracking logs
            foreach (var result in results)
            {
                SubmissionResultDL.AddResult(result);
            }

            // Return the evaluation summary to pass back to the UI form
            return results;
        }
        public static List<SubmissionResult> EvaluateQuery(int submissionID, int problemID, string studentQuery)
        {
            // Retrieve all test cases for the problem
            List<TestCase> testCases = TestCaseBL.GetByProblemID(problemID);
            List<SubmissionResult> results = new List<SubmissionResult>();

            foreach (TestCase tc in testCases)
            {
                SubmissionResult result = new SubmissionResult
                {
                    SubmissionID = submissionID,
                    TestCaseID = tc.TestCaseID,
                    IsPassed = false,
                    ErrorMessage = ""
                };

                DataTable expectedResult;

                // Isolate Instructor/Admin baseline query execution
                try
                {
                    expectedResult = QueryRunnerDB.Instance.ExecuteTransactionViaSql(tc.SetupSQL, tc.SolutionQuery);
                }
                catch (Exception)
                {
                    result.IsPassed = false;
                    result.ErrorMessage = "System Error: The environment configuration for this test case is broken. Please contact your instructor.";
                    results.Add(result);
                    continue;
                }

                // Run student query inside protected sandbox 
                try
                {
                    DataTable studentResult = QueryRunnerDB.Instance.ExecuteStudentSubmission(tc.SetupSQL, studentQuery);

                    string mismatchReason = "";
                    result.IsPassed = CompareTables(expectedResult, studentResult, out mismatchReason);

                    result.ErrorMessage = result.IsPassed ? "Passed" : mismatchReason;
                }
                catch (InvalidOperationException ex) when (ex.Message == "SETUP_FAULT")
                {
                    // Shield student from setup-induced duplicate errors or syntax adjustments
                    result.IsPassed = false;
                    result.ErrorMessage = "System Error: Evaluation environment failed to initialize properly. Please retry or contact your instructor.";
                }
                catch (MySqlException sqlEx)
                {
                    // Clear student error reporting for mistakes in their personal query
                    result.IsPassed = false;
                    result.ErrorMessage = $"Runtime SQL Error: {sqlEx.Message}";
                }
                catch (Exception ex)
                {
                    result.IsPassed = false;
                    result.ErrorMessage = $"System Error: {ex.Message}";
                }

                results.Add(result);
            }
            return results;
        }
        private static bool CompareTables(DataTable expected, DataTable student, out string mismatchReason)
        {
            mismatchReason = "";

            if (expected.Rows.Count != student.Rows.Count)
            {
                mismatchReason = $"Row count mismatch. Expected: {expected.Rows.Count}, Got: {student.Rows.Count}.";
                return false;
            }

            if (expected.Columns.Count != student.Columns.Count)
            {
                mismatchReason = $"Column count mismatch. Expected: {expected.Columns.Count}, Got: {student.Columns.Count}.";
                return false;
            }

            for (int i = 0; i < expected.Rows.Count; i++)
            {
                for (int j = 0; j < expected.Columns.Count; j++)
                {
                    if (expected.Rows[i][j]?.ToString() != student.Rows[i][j]?.ToString())
                    {
                        mismatchReason = $"Data mismatch at Row {i + 1}, Column '{expected.Columns[j].ColumnName}'.";
                        return false;
                    }
                }
            }

            return true;
        }

        // Submission Panel in Admin Dashboard
        public static DataTable GetSubmissions()
        {
            return SubmissionDL.GetSubmissionsForAdmin();
        }
        public static int TotalSubmissions()
        {
            return SubmissionDL.TotalSubmissions();
        }
        public static int AcceptedSubmissions()
        {
            return SubmissionDL.AcceptedSubmissions();
        }
        public static int RejectedSubmissions()
        {
            return SubmissionDL.RejectedSubmissions();
        }
    }
}
