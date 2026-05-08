using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class ProblemDL
    {
        public static int TotalProblems()
        {
            string query = "SELECT COUNT(*) FROM Problems;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
    }
}
