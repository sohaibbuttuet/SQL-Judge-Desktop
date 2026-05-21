using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemDifficulty
    {
        private int difficultyID;
        private string name;
        public int DifficultyID
        {
            get { return difficultyID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Difficulty ID.");
                difficultyID = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Difficulty Name cannot be empty.");
                name = value;
            }
        }
        public ProblemDifficulty() { }
        public ProblemDifficulty(int difficultyID, string name)
        {
            DifficultyID = difficultyID;
            Name = name;
        }
    }
}
