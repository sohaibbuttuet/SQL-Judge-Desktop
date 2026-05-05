using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SkillLevel
    {
        public int SkillLevelID { get; set; }
        public string LevelName { get; set; }

        public SkillLevel()
        {
        }
        public SkillLevel(int skillLevelID, string levelName)
        {
            SkillLevelID = skillLevelID;
            LevelName = levelName;
        }
    }
}
