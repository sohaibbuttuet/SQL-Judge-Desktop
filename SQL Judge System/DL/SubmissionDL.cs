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
            string query = "INSERT INTO Submissions (StudentID, ProblemID, QueryText) " +
                    "VALUES (@StudentID, @ProblemID, @QueryText); " +
                    "SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", submission.StudentID),
                new MySqlParameter("@ProblemID", submission.ProblemID),
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
            string query = $"SELECT COUNT(*) FROM Submissions WHERE StatusID = @StatusID;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@StatusID", SubmissionStatusDL.GetAccepted())
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
        public static int RejectedSubmissions()
        {
            string query = $"SELECT COUNT(*) FROM Submissions WHERE StatusID <> @StatusID;";

            MySqlParameter[] parameters = {
                new MySqlParameter("@StatusID", SubmissionStatusDL.GetAccepted())
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }
    }
}