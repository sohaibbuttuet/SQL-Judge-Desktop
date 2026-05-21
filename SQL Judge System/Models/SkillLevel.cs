using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SkillLevel
    {
        private int skillLevelID;
        private string skillName;

        public int SkillLevelID
        {
            get { return skillLevelID; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SkillLevelID must be a positive integer.");
                }
                skillLevelID = value;
            }
        }
        public string SkillName
        {
            get { return skillName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("SkillName cannot be null or empty.");
                }
                skillName = value;
            }
        }

        public SkillLevel() { }
        public SkillLevel(int skillLevelID, string skillName)
        {
            SkillLevelID = skillLevelID;
            SkillName = skillName;
        }
    }
}