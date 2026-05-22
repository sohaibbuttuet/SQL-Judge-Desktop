using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.LookupDL
{
    internal class ProblemDifficultiesDL
    {
        public static List<ProblemDifficulty> GetProblemDifficulties()
        {
            string query = "SELECT DifficultyID, DifficultyName FROM ProblemDifficulties";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ProblemDifficulty> list = new List<ProblemDifficulty>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new ProblemDifficulty(Convert.ToInt32(dr["DifficultyID"]), dr["DifficultyName"].ToString()));
            }
            return list;
        }
    }
}
