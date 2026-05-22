using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class SubmissionDL
    {        
        public static int AddSubmission(Submission submission)
        {
            string query = "INSERT INTO Submissions (StudentID, ProblemID, QueryText, StatusID, AttemptNumber, TotalScore, SubmittedAt) " +
                           $"VALUES ({submission.StudentID}, {submission.ProblemID}, {submission.QueryText}, {submission.StatusID}, {submission.AttemptNumber}, {submission.TotalScore}); " +
                           "SELECT LAST_INSERT_ID();";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }

        public static DataTable GetSubmissionsForAdmin()
        {
            string query = "SELECT * FROM vw_Submissions;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int TotalSubmissions()
        {
            string query = $"SELECT COUNT(*) FROM vw_Submissions;";
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