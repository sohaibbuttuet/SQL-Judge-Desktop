using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.LookupDL
{
    internal class ProblemTagsDL
    {
        public static DataTable GetAll()
        {
            string query = "SELECT TagID, TagName FROM ProblemTags;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
