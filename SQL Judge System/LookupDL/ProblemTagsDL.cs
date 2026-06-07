using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.LookupDL
{
    internal class ProblemTagsDL
    {
        public static List<ProblemTag> GetProblemTags()
        {
            string query = "SELECT * FROM ProblemTags ORDER BY TagID;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ProblemTag> tags = new List<ProblemTag>();

            foreach (DataRow dr in dt.Rows)
            {
                tags.Add(new ProblemTag(Convert.ToInt32(dr["TagID"]), dr["TagName"].ToString()));
            }

            return tags;
        }
    }
}
