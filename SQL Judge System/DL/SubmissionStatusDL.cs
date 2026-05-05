using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidDb26_2025CS259;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class SubmissionStatusDL
    {
        public static List<SubmissionStatus> GetAll()
        {
            string query = "SELECT * FROM SubmissionStatus;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<SubmissionStatus> statuses = new List<SubmissionStatus>();
            foreach (DataRow row in dt.Rows)
            {
                statuses.Add(new SubmissionStatus
                {
                    StatusID = Convert.ToInt32(row["StatusID"]),
                    StatusName = row["StatusName"].ToString()
                });
            }
            return statuses;
        }
        public static int GetStatusIDByName(string statusName)
        {
            string query = $"SELECT StatusID FROM SubmissionStatus WHERE StatusName = '{statusName}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}

