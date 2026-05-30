using MySql.Data.MySqlClient;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class SubmissionDL
    {
        public static int AddSubmission(Submission submission)
        {
            string query = "INSERT INTO Submissions (StudentID, ProblemID, QueryText, AttemptNumber, StatusID) " +
                    "VALUES (@StudentID, @ProblemID, @QueryText, @AttemptNumber, @StatusID); " +
                    "SELECT LAST_INSERT_ID();";

            // Bundle the object values safely into the parameter array
            MySqlParameter[] parameters = {
            new MySqlParameter("@StudentID", submission.StudentID),
            new MySqlParameter("@ProblemID", submission.ProblemID),
            new MySqlParameter("@QueryText", submission.QueryText), 
            new MySqlParameter("@AttemptNumber", submission.AttemptNumber),
            new MySqlParameter("@StatusID", submission.StatusID)   
            };


            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
        public static void UpdateSubmission(Submission submission)
        {
            string query = "UPDATE Submissions SET StatusID = @StatusID, TotalScore = @TotalScore WHERE SubmissionID = @SubmissionID;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@StatusID", submission.StatusID),
                new MySqlParameter("@TotalScore", submission.TotalScore),
                new MySqlParameter("@SubmissionID", submission.SubmissionID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static int GetAttempts(int studentID, int problemID)
        {
            string query = $"SELECT COUNT(*) FROM Submissions WHERE StudentID = {studentID} AND ProblemID = {problemID};";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static bool HasAcceptedSubmission(int studentID, int problemID)
        {
            string query = $"SELECT COUNT(*) FROM Submissions WHERE StudentID = {studentID} AND ProblemID = {problemID} AND StatusID = {SubmissionStatusDL.GetAccepted()};";

            return DatabaseHelper.Instance.ExecuteScalar(query) > 0;
        }

        // Submission Panel in Admin Dashboard
        public static DataTable GetSubmissionsForAdmin()
        {
            string query = "SELECT * FROM vw_Submissions;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalSubmissions()
        {
            string query = $"SELECT COUNT(*) FROM Submissions;";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int AcceptedSubmissions()
        {
            string query = $"SELECT COUNT(*) FROM vw_Submissions WHERE Status = 'Accepted';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int RejectedSubmissions()
        {
            string query = $"SELECT COUNT(*) FROM vw_Submissions WHERE Status <> 'Accepted';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
    }
}