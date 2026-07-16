using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Helper
{
    internal class ReportsDL
    {
        public static DataTable StudentMetrices(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(*) FROM students) AS TotalStudents,
                    (SELECT ROUND(AVG(ProblemsSolved),1) FROM students) AS AvgProblemsSolved,
                    (SELECT COUNT(DISTINCT StudentID)
                     FROM contestparticipants
                     WHERE JoinedAt BETWEEN @StartDate AND @EndDate) AS ContestRegisteredStudent;";

            MySqlParameter[] param =
            {
                new MySqlParameter("@StartDate", startDate),
                new MySqlParameter("@EndDate", endDate)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, param);

            if (dt.Rows.Count == 0)
                return null;

            return dt;
        }
        public static DataTable StudentSubmissionMetrices(int studentID, DateTime startDate, DateTime endDate)
        {
            string query = @"
    SELECT 
        COUNT(SubmissionID) AS TotalSubmissions,
        SUM(StatusID = 1) AS AcceptedSubmissions,
        IFNULL(SUM(TotalScore), 0) AS TotalPoints,
        IFNULL(
            ROUND(
                (SUM(StatusID = 1) * 100.0) / NULLIF(COUNT(SubmissionID), 0),
                1
            ),
            0.0
        ) AS SuccessRate
    FROM submissions
    WHERE StudentID = @StudentID
      AND SubmittedAt BETWEEN @StartDate AND @EndDate;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", studentID),
                new MySqlParameter("@StartDate", startDate.Date),
                new MySqlParameter("@EndDate",   endDate.Date.AddDays(1).AddTicks(-1))
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }
        public static DataTable GetSubmissionMetrics(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    COUNT(SubmissionID) AS TotalSubmissions, 
                    SUM(StatusID = 4)   AS PendingSubmissions, 
                    IFNULL(ROUND((SUM(StatusID = 1) / COUNT(SubmissionID)) * 100, 1), 0.0) AS PassRate,
                    SUM(StatusID = 3)   AS RunTimeErrorCount
                FROM submissions
                WHERE SubmittedAt BETWEEN @StartDate AND @EndDate;";

            MySqlParameter[] param =
            {
                new MySqlParameter("@StartDate", startDate.Date),
                new MySqlParameter("@EndDate",   endDate.Date.AddDays(1).AddTicks(-1))
            };

            return DatabaseHelper.Instance.GetDataTable(query, param);
        }
        public static DataTable ContestMetrics(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    (SELECT COUNT(ContestID) 
                     FROM contests
                     WHERE StartDate BETWEEN @StartDate AND @EndDate) AS TotalContests,
                    IFNULL(MAX(ContestScore), 0) AS MaxContestScore,
                    IFNULL(ROUND(AVG(ContestScore), 2), 0.00) AS AvgContestScore
                FROM (
                    SELECT 
                        ContestID,
                        SUM(TotalScore) AS ContestScore
                    FROM submissions
                    WHERE ContestID IS NOT NULL
                      AND SubmittedAt BETWEEN @StartDate AND @EndDate
                    GROUP BY ContestID
                ) AS ContestStats;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StartDate", startDate.Date),
                new MySqlParameter("@EndDate",   endDate.Date.AddDays(1).AddTicks(-1))
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }
        public static DataTable ContestCompletionRate(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT 
                    IFNULL(
                        ROUND(
                            COUNT(*) * 100.0 /
                            NULLIF(
                                (SELECT COUNT(*)
                                 FROM contestparticipants
                                 WHERE JoinedAt BETWEEN @StartDate AND @EndDate),
                                0
                            ),
                            1
                        ),
                        0.0
                    ) AS CompletionRate
                FROM (
                    SELECT s.ContestID, s.StudentID
                    FROM submissions s
                    JOIN contestproblems cp ON s.ContestID = cp.ContestID
                    WHERE s.ContestID IS NOT NULL
                      AND s.StatusID = 1
                      AND s.SubmittedAt BETWEEN @StartDate AND @EndDate
                    GROUP BY s.ContestID, s.StudentID
                    HAVING COUNT(DISTINCT s.ProblemID) = COUNT(DISTINCT cp.ProblemID)
                ) AS CompletedStudents;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StartDate", startDate.Date),
                new MySqlParameter("@EndDate",   endDate.Date.AddDays(1).AddTicks(-1))
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }
    }
}

// ==========================================================
// STUDENT METRICS REPORT
// ==========================================================
// Purpose:
// Provides high-level statistics about students within a
// selected reporting period.
//
// Metrics:
// 1. TotalStudents
//    - Total number of registered students.
//
// 2. AvgProblemsSolved
//    - Average number of problems solved by students.
//    - Indicates overall student performance.
//
// 3. ContestRegisteredStudent
//    - Number of unique students who joined contests
//      during the selected date range.
//    - Measures contest participation and engagement.
// ==========================================================


// ==========================================================
// STUDENT SUBMISSION METRICS REPORT
// ==========================================================
// Purpose:
// Provides performance analytics for a specific student
// within a selected date range.
//
// Metrics:
// 1. TotalSubmissions
//    - Total submissions made by the student.
//
// 2. HighestPoints
//    - Highest score achieved by the student.
//
// 3. AveragePoints
//    - Average score across all submissions.
//
// 4. SuccessRate
//    - Percentage of accepted submissions.
//    - Formula:
//      Accepted Submissions / Total Submissions × 100
//
// Business Value:
// Helps evaluate student consistency, effectiveness,
// and progress over time.
// ==========================================================


// ==========================================================
// SUBMISSION SYSTEM METRICS REPORT
// ==========================================================
// Purpose:
// Provides overall system-wide submission analytics.
//
// Metrics:
// 1. TotalSubmissions
//    - Total submissions received by the system.
//
// 2. PendingSubmissions
//    - Submissions awaiting evaluation.
//
// 3. PassRate
//    - Percentage of accepted submissions.
//    - Formula:
//      Accepted Submissions / Total Submissions × 100
//
// 4. RunTimeErrorCount
//    - Number of submissions resulting in runtime errors.
//
// Business Value:
// Helps administrators monitor platform health,
// submission quality, and evaluation effectiveness.
// ==========================================================


// ==========================================================
// CONTEST METRICS REPORT
// ==========================================================
// Purpose:
// Provides summary analytics about contests.
//
// Metrics:
// 1. TotalContests
//    - Total contests created within the reporting period.
//
// 2. MaxContestScore
//    - Highest cumulative score achieved in any contest.
//
// 3. AvgContestScore
//    - Average cumulative contest score.
//
// Business Value:
// Measures contest competitiveness and overall
// participant performance.
// ==========================================================


// ==========================================================
// CONTEST COMPLETION RATE REPORT
// ==========================================================
// Purpose:
// Measures how many participants successfully completed
// all contest problems.
//
// Completion Definition:
// A participant is considered to have completed a contest if:
//
// 1. The participant has an Accepted submission
//    (StatusID = 1)
//
// 2. The participant has solved every problem assigned
//    to that contest.
//
// Formula:
// Completed Participants
// ---------------------- × 100
// Total Contest Participants
//
// Metrics:
// 1. CompletionRate
//    - Percentage of contest participants who completed
//      all contest problems successfully.
//
// Business Value:
// Indicates contest difficulty, participant persistence,
// and overall contest success.
// ==========================================================
