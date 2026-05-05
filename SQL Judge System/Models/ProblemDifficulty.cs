using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemDifficulty
    {
        public int DifficultyID { get; set; }
        public string DifficultyName { get; set; }

        public ProblemDifficulty()
        {
        }
        public ProblemDifficulty(int difficultyID, string difficultyName)
        {
            DifficultyID = difficultyID;
            DifficultyName = difficultyName;
        }
    }
}
