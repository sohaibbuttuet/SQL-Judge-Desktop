using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Problem
    {
        public int ProblemID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DifficultyID { get; set; }  // nullable FK → ProblemDifficulties
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; } 

        public Problem()
        {
            CreatedAt = DateTime.Now;
            Score = 0;
        }
        public Problem(int problemID, string title, string description, int difficultyID, int score)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
            Score = score;
            CreatedAt = DateTime.Now;   
        }
    }
}
