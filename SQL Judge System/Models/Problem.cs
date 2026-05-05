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
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public Problem(int problemID, string title, string description, int difficultyID)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
        }
    }
}
