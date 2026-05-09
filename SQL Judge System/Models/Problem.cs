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
        public int Points { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public bool IsActive { get; set; } 

        public Problem()
        {
            CreatedAt = DateTime.Now;
            Points = 10;
            IsActive = true;
        }
        public Problem(int problemID, string title, string description, int difficultyID, int points)
        {
            ProblemID = problemID;
            Title = title;
            Description = description;
            DifficultyID = difficultyID;
            Points = points;
            CreatedAt = DateTime.Now;   
            IsActive = true;
        }
    }
}
