using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.BL
{
    internal class SubmissionBL
    {
        // ==========================================
        // SUBMISSION MANAGEMENT
        // ==========================================
        public static void CreateSubmission(Submission submission)
        {
            if (submission == null)
                throw new ArgumentNullException(nameof(submission), "Submission record cannot be null.");
            if (submission.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID specified.", nameof(submission.ProblemID));
            if (submission.StudentID <= 0)
                throw new ArgumentException("Invalid Student ID specified.", nameof(submission.StudentID));

            submission.SubmissionID = SubmissionDL.AddSubmission(submission);
        }
        public static void UpdateSubmissionStatus(int submissionID, int statusID)
        {
            if (submissionID <= 0)
                throw new ArgumentException("Invalid Submission ID specified.", nameof(submissionID));
            if (statusID <= 0)
                throw new ArgumentException("Invalid Status ID specified.", nameof(statusID));

            SubmissionDL.UpdateSubmissionStatus(submissionID, statusID);
        }
        public static void AddSubmissionResult(SubmissionResult result)
        {
            if (result == null)
                throw new ArgumentNullException(nameof(result), "SubmissionResult data cannot be null.");
            if (result.SubmissionID <= 0)
                throw new ArgumentException("Invalid Submission ID mapping.", nameof(result.SubmissionID));

            SubmissionResultDL.AddResult(result);
        }

        // ==========================================
        // CORE SANDBOX EXECUTION & GRADING ENGINE
        // ==========================================
        public static SubmissionResult ProcessAndGradeSubmission(int studentID, int problemID, int? contestID, string query, string databaseName)
        {
            // 1. Create a new submission record with "Pending" status
            int pendingStatusID = SubmissionStatusDL.GetPending();
            Submission submission = new Submission(studentID, problemID, contestID, query, pendingStatusID);

            // This will generate a new SubmissionID and save the record in the database with "Pending" status
            CreateSubmission(submission);

            // 2. Fetch problem constraints: Allowed Tables and Master Query
            List<ProblemTable> allowedTables = ProblemBL.GetSelectedTablesByProblemID(problemID);
            List<string> allowedTableNames = allowedTables.Select(t => t.TableName).ToList();
            string masterQuery = ProblemBL.GetProblemByID(problemID).MasterQuery;

            // 3. Initialize a result object to capture the grading outcome and any error messages
            SubmissionResult submissionResult = new SubmissionResult
            {
                SubmissionID = submission.SubmissionID,
                IsPassed = false,
                ErrorMessage = ""
            };

            DataTable studentOutput = null;
            DataTable expectedOutput = null;

            // 4. Try Running Student Query with strict validation and error handling
            try
            {
                studentOutput = QueryRunnerBL.ExecuteQuery(databaseName, query, allowedTableNames);
            }
            catch (ArgumentException validationEx) 
            {
                // Handle validation errors such as disallowed tables, syntax issues, or other query constraints
                UpdateSubmissionStatus(submission.SubmissionID, SubmissionStatusDL.GetWrongAnswer());
                submissionResult.ErrorMessage = validationEx.Message;
                AddSubmissionResult(submissionResult);
                throw; // rethrow 
            }
            catch (Exception ex) 
            {
                // Handle compilation or server-level database engine syntax runtime crashes
                UpdateSubmissionStatus(submission.SubmissionID, SubmissionStatusDL.GetRunTimeError());
                submissionResult.ErrorMessage = "Runtime error during query execution: " + ex.Message;
                AddSubmissionResult(submissionResult);
                return submissionResult;
            }

            // 5. Try Running Master Query
            try
            {                
                expectedOutput = QueryRunnerBL.ExecuteQuery(databaseName, masterQuery, allowedTableNames);
            }
            catch (Exception ex)
            {
                // System failure running the master query. Rollback status to pending for admin oversight
                UpdateSubmissionStatus(submission.SubmissionID, SubmissionStatusDL.GetPending());
                submissionResult.ErrorMessage = "System error while fetching expected output: " + ex.Message;
                AddSubmissionResult(submissionResult);
                return submissionResult;
            }

            // 6. Compare Table Contents 
            string mismatchReason;
            bool isCorrect = QueryRunnerBL.CompareTables(expectedOutput, studentOutput, out mismatchReason);

            if (isCorrect)
            {
                UpdateSubmissionStatus(submission.SubmissionID, SubmissionStatusDL.GetAccepted());
                submissionResult.IsPassed = true;
                submissionResult.ErrorMessage = "";
            }
            else
            {
                UpdateSubmissionStatus(submission.SubmissionID, SubmissionStatusDL.GetWrongAnswer());
                submissionResult.IsPassed = false;
                submissionResult.ErrorMessage = mismatchReason;
            }

            // 7. Record the grading result in the database
            AddSubmissionResult(submissionResult);
            return submissionResult;
        }

        // ==========================================
        // ADMIN DASHBOARD ANALYTICS COUNTERS
        // ==========================================
        public static DataTable GetSubmissions()
        {
            return SubmissionDL.GetSubmissionsForAdmin();
        }
        public static int AttemptNumber(int studentID, int problemID)
        {
            if (studentID <= 0)
                throw new ArgumentException("Invalid Studnet ID");

            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            return SubmissionDL.GetAttemptNumber(studentID, problemID);
        }
        public static int GetContestAttempts(int studentID, int contestID)
        {
            if (studentID <= 0)
                throw new ArgumentOutOfRangeException(nameof(studentID), "Invalid Student ID");
            if (contestID <= 0)
                throw new ArgumentOutOfRangeException(nameof(studentID), "Invalid Contest ID");

            return SubmissionDL.GetContestAttemptNumber(studentID, contestID);
        }
        public static string StatusOfLastSubmission(int studentID, int problemID)
        {
            if (studentID <= 0)
                throw new ArgumentException("Invalid Studnet ID");

            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            return SubmissionStatusDL.StatusOfLastSubmission(studentID, problemID);
        }

        // Reports
        public static DataTable GetSubmissions(int limit, DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate || limit <= 0)
            {
                return new DataTable();
            }

            return SubmissionDL.GetSubmissions(limit, startDate, endDate);
        }
        public static DataTable GetSubmissionsByStudent(int studentId, int limit, DateTime startDate, DateTime endDate)
        {
            if (studentId <= 0)
            {
                return new DataTable(); // Return clean empty table framework if ID is invalid
            }

            if (startDate > endDate)
            {
                return new DataTable(); // Return empty table if dates are logically backwards
            }

            if (limit <= 0)
            {
                limit = 10; // Default fallback to top 10 rows if limit is invalid
            }

            return SubmissionDL.GetSubmissionsByStudent(studentId, limit, startDate, endDate);
        }
    }
}
