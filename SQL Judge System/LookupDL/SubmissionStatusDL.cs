using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;

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
    }
}

