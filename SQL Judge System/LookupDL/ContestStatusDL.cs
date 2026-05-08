using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.LookupDL
{
    internal class ContestStatusDL
    {
        public static DataTable GetAll()
        {
            string query = "SELECT StatusID, StatusName FROM ContestStatus;";
            return DatabaseHelper.Instance.GetDataTable(query);           
        }
    }
}
