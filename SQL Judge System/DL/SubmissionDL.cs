using MySql.Data.MySqlClient ;
using SQL_Judge_System.Helper;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.DL
{
    internal class SubmissionDL
    {
        public static int AddSubmission(Submission submission)
        {
            string query = "INSERT INTO Submissions (StudentID, ProblemID, contestID, QueryText) " +
                    "VALUES (@StudentID, @ProblemID, @ContestID, @QueryText); " +
                    "SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", submission.StudentID),
                new MySqlParameter("@ProblemID", submission.ProblemID),
                new MySqlParameter("@ContestID", submission.ContestID.HasValue ? (object)submission.ContestID.Value : DBNull.Value),
                new MySqlParameter("@QueryText", submission.QueryText)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
        public static void UpdateSubmissionStatus(int submissionID, int statusID)
        {
            string query = "UPDATE Submissions SET StatusID = @StatusID WHERE SubmissionID = @SubmissionID;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@StatusID", statusID),
                new MySqlParameter("@SubmissionID", submissionID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }

        // ==========================================
        // ADMIN DASHBOARD ANALYTICS PANEL RETRIEVALS
        // ==========================================
        public static DataTable GetSubmissionsForAdmin()
        {
            string query = "SELECT * FROM vw_Submissions;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int GetAttemptNumber(int studentID, int problemID)
        {
            string query = "SELECT MAX(AttemptNumber) FROM submissions WHERE StudentID = @StudentID AND ProblemID = @ProblemID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", studentID),
                new MySqlParameter("@ProblemID", problemID)
            };

            int count = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return count != -1 ? count : 0;
        }
        public static int GetContestAttemptNumber(int studentID, int contestID)
        {
            string query = "SELECT MAX(AttemptNumber) FROM submissions WHERE StudentID = @StudentID AND ContestID = @ContestID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", studentID),
                new MySqlParameter("@ContestID", contestID)
            };

            int count = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return count != -1 ? count : 0;
        }


        // Reports
        public static DataTable GetSubmissions(int limit, DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT * FROM vw_Submissions 
                     WHERE SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate
                     ORDER BY SubmittedAt DESC 
                     LIMIT @Limit;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@Limit", limit),
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static DataTable GetSubmissionsByStudent(int studentID, int limit, DateTime startDate, DateTime endDate)
        {
            // Fix 1: Inject the integer limit directly into the query to prevent driver formatting crashes
            // Fix 2: Add date window filters to match your business layer and UI controls
            string query = $@"SELECT StudentName, ProblemTitle, TotalScore, AttemptNumber, SubmittedAt, Status FROM vw_Submissions 
                     WHERE StudentID = @StudentID 
                       AND SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate
                     ORDER BY SubmittedAt DESC 
                     LIMIT {limit};";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StudentID", studentID),
        new MySqlParameter("@StartDate", startDate.Date),
        new MySqlParameter("@EndDate", endDate.Date)
    };

            // Aligned to use your project's unified DatabaseHelper execution method
            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static DataTable GetStudentSubmissionMetrics(int studentID, DateTime startDate, DateTime endDate)
        {
            // Evaluates all four tracking vectors safely in a single high-performance query execution
            string query = @"SELECT 
                        COUNT(SubmissionID) AS TotalSubmissions,
                        IFNULL(MAX(TotalScore), 0) AS HighestPoints,
                        IFNULL(ROUND(AVG(TotalScore), 2), 0.00) AS AveragePoints,
                        IFNULL(ROUND((SUM(StatusID = 1) / COUNT(SubmissionID)) * 100, 1), 0.0) AS SuccessRate
                     FROM submissions
                     WHERE StudentID = @StudentID
                       AND SubmittedAt >= @StartDate
                       AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StudentID", studentID),
        new MySqlParameter("@StartDate", startDate.Date),
        new MySqlParameter("@EndDate", endDate.Date.AddDays(1).AddTicks(-1))
    };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static int SubmittedContestProblems(int contestID, int studentID)
        {
            string query = $"SELECT DISTINCT COUNT(problemID) FROM submissions WHERE ContestID = @ContestID AND StudentID = @StudentID AND StatusID = @StatusID";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", contestID),
                new MySqlParameter("@StatusID", SubmissionStatusDL.GetAccepted()),
                new MySqlParameter("@StudentID", studentID)
            };

            int result = DatabaseHelper.Instance.ExecuteScalar(query,parameters);
            return result != -1 ? result : 0;
        }
        public static int RunTimeErrorCount(DateTime startDate, DateTime endDate)
        {
            // Added date range check to your core query syntax
            string query = @"SELECT COUNT(*) FROM submissions 
                     WHERE statusID = @StatusID 
                       AND SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StatusID", SubmissionStatusDL.GetRunTimeError()),
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
        public static int PendingStatusCount(DateTime startDate, DateTime endDate)
        {
            // Added date range check to your core query syntax
            string query = @"SELECT COUNT(*) FROM submissions 
                     WHERE statusID = @StatusID 
                       AND SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StatusID", SubmissionStatusDL.GetPending()),
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
        public static int CorrectSubCount(DateTime startDate, DateTime endDate)
        {
            // Added date range check to your core query syntax
            string query = @"SELECT COUNT(*) FROM submissions 
                     WHERE statusID = @StatusID 
                       AND SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StatusID", SubmissionStatusDL.GetAccepted()),
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
        public static int HighestScore(DateTime startDate, DateTime endDate)
        {
            // Calculates the maximum combined score achieved by any single student within the active period
            string query = @"SELECT IFNULL(MAX(StudentScores), 0) AS HighestScore 
                             FROM (
                                  SELECT SUM(TotalScore) AS StudentScores 
                                  FROM submissions 
                                  WHERE ContestID IS NOT NULL 
                                  AND SubmittedAt >= @StartDate 
                                  AND SubmittedAt <= @EndDate
                                  GROUP BY StudentID
                                  ) AS ScoreSubQuery;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StartDate", startDate),
                new MySqlParameter("@EndDate", endDate)
            };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
        public static double AverageScore(DateTime startDate, DateTime endDate)
        {
            // Fixed Bug: The WHERE clause for dates must live inside the inner aggregation subquery
            string query = @"SELECT IFNULL(ROUND(AVG(StudentScores), 2), 0.00) AS AverageScore 
                             FROM (
                                    SELECT SUM(TotalScore) AS StudentScores 
                                    FROM submissions 
                                    WHERE ContestID IS NOT NULL 
                                    AND SubmittedAt >= @StartDate 
                                    AND SubmittedAt <= @EndDate
                                    GROUP BY StudentID
                                  ) AS ScoreSubQuery;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
        }
        public static double OverallCompletionRate(DateTime startDate, DateTime endDate)
        {
            // Clean, single-pass simplified MySQL query
            string query = @"SELECT IFNULL(ROUND((SUM(statusID = 1) / COUNT(SubmissionID)) * 100, 1), 0.0) AS CompletionRate
        FROM submissions
        WHERE ContestID IS NOT NULL 
          AND SubmittedAt >= @StartDate 
          AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0.0;
        }
        public static int GetContestRegisteredStudents(DateTime startDate, DateTime endDate)
        {
            // Counts distinct students who actually registered for or participated in any contest in this period
            // Uses a subquery join check to keep the main count fast
            string query = @"SELECT COUNT(DISTINCT studentID) FROM submissions 
                     WHERE ContestID IS NOT NULL 
                       AND SubmittedAt >= @StartDate 
                       AND SubmittedAt <= @EndDate;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
    }
}
