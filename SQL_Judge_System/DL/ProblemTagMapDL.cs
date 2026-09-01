using MySql.Data.MySqlClient;
using SQL_Judge_System.BL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.DL
{
    internal class ProblemTagMapDL
    {
        public static void MapProblemTag(ProblemTagMap pt)
        {
            string query = "INSERT INTO problemtagmap (ProblemID, TagID) VALUES (@ProblemID, @TagID);";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProblemID", pt.ProblemID),
                new MySqlParameter("@TagID", pt.TagID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static void DeleteByProblemID(int problemID)
        {
            string query = "DELETE FROM problemtagmap WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProblemID", problemID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static List<ProblemTagMap> GetProblemTags(int problemID)
        {
            string query = "SELECT * FROM ProblemTagMap WHERE ProblemID = @ProblemID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ProblemID", problemID)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);
            List<ProblemTagMap> tags = new List<ProblemTagMap>();

            foreach (DataRow dr in dt.Rows)
            {
                ProblemTagMap tag = new ProblemTagMap(
                    Convert.ToInt32(dr["ProblemID"]),
                    Convert.ToInt32(dr["TagID"])
                );
                tags.Add(tag);
            }
            return tags;
        }
    }
}
