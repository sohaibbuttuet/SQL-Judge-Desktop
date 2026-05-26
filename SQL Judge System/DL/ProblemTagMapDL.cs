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
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteByProblemID(int problemID)
        {
            string query = $"DELETE FROM problemtagmap WHERE ProblemID = {problemID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static List<ProblemTagMap> GetProblemTags(int problemID)
        {
            string query = $"SELECT * FROM ProblemTagMap WHERE ProblemID = {problemID};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<ProblemTagMap> tags = new List<ProblemTagMap>();
            foreach (DataRow dr in dt.Rows)
            {
                ProblemTagMap tag = new ProblemTagMap((int)dr["ProblemID"], (int)dr["TagID"]);
                tags.Add(tag);
            }
            return tags;
        }
    }
}
