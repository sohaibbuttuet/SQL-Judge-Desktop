using MySql.Data.MySqlClient ;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Helper;

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
    }
}
