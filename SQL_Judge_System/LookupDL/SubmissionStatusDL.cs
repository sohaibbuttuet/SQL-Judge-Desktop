using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.LookupDL
{
    internal class SubmissionStatusDL
    {
        public static List<SubmissionStatus> GetAll()
        {
            string query = "SELECT * FROM SubmissionStatuses ORDER BY StatusID;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);    

            List<SubmissionStatus> statuses = new List<SubmissionStatus>();
            foreach(DataRow row in dt.Rows)
            {
                SubmissionStatus status = new SubmissionStatus(Convert.ToInt32(row["StatusID"]), row["StatusName"].ToString());
                statuses.Add(status);
            }
            return statuses;
        }
        public static int GetAccepted()
        {
            string query = "SELECT StatusID FROM SubmissionStatuses WHERE StatusName = 'Accepted';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int GetWrongAnswer()
        {
            string query = "SELECT StatusID FROM SubmissionStatuses WHERE StatusName = 'Wrong Answer';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int GetRunTimeError()
        {
            string query = "SELECT StatusID FROM SubmissionStatuses WHERE StatusName = 'Runtime Error';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static int GetPending()
        {
            string query = "SELECT StatusID FROM SubmissionStatuses WHERE StatusName = 'Pending';";
            return DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static string StatusOfLastSubmission(int studentID, int problemID)
        {
            string query = "SELECT ss.StatusName FROM submissionstatuses ss JOIN submissions s ON ss.StatusID = s.StatusID WHERE s.StudentID = @StudentID AND s.ProblemID = @ProblemID ORDER BY s.SubmittedAt DESC, s.SubmissionID DESC LIMIT 1;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudentID", studentID),
                new MySqlParameter("@ProblemID", problemID)
            };

            object result = DatabaseHelper.Instance.ExecuteScalarObject(query, parameters);

            if (result == null || result == DBNull.Value)
            {
                return string.Empty;
            }

            return result.ToString();
        }
    }
}
