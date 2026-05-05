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
    internal class SkillLevelDL
    {
        public static List<SkillLevel> GetAll()
        {         
            string query = "SELECT * FROM SkillLevels";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<SkillLevel> skillLevels = new List<SkillLevel>();
            foreach (DataRow row in dt.Rows)
            {
                skillLevels.Add(new SkillLevel
                {
                    SkillLevelID = Convert.ToInt32(row["SkillLevelID"]),
                    LevelName = row["LevelName"].ToString()
                });              
            }
            return skillLevels;
        }
    }
}
