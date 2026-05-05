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
    internal class ContestStatusDL
    {
        public static List<ContestStatus> GetAll()
        {
            string query = "SELECT * FROM ContestStatus;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ContestStatus> contestStatuses = new List<ContestStatus>();
            foreach (DataRow row in dt.Rows)
            {
                ContestStatus contestStatus = new ContestStatus
                {
                    StatusID = Convert.ToInt32(row["StatusID"]),
                    StatusName = row["StatusName"].ToString()
                };
                contestStatuses.Add(contestStatus); 
            }
            return contestStatuses;
        }
        public static int GetIDByName(string statusName)
        {
            string query = $"SELECT StatusID FROM ContestStatus WHERE StatusName = '{statusName}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}
