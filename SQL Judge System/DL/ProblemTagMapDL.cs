using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class ProblemTagMapDL
    {
        public static void MapProblemTag(ProblemTagMap pt)
        {
            string query = $"INSERT INTO problemtagmap(ProblemID, TagID) VALUES ({pt.ProblemID},{pt.TagID});";
            DatabaseHelper.Instance.ExecuteScalar(query);
        }
        public static void DeleteByProblemID(int problemID)
        {
            string query = $"DELETE FROM problemtagmap WHERE ProblemID = {problemID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<int> GetTagIDs(int problemId)
        {
            string query = $"SELECT TagId FROM ProblemTagMap WHERE ProblemID = {problemId};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<int> tagIDs = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                tagIDs.Add(Convert.ToInt32(row["TagID"]));
            }

            return tagIDs;
        }
    }
}
