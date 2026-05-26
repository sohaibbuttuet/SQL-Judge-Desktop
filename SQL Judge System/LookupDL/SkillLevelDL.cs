using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace SQL_Judge_System.LookupDL
{
    internal class SkillLevelDL
    {
        public static List<SkillLevel> GetAll()
        {         
            string query = "SELECT * FROM SkillLevels ORDER BY SkillLevelID;";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<SkillLevel> list = new List<SkillLevel>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SkillLevel(Convert.ToInt32(row["SkillLevelID"]), row["LevelName"].ToString()));
            }

            return list;
        }
    }
}          
