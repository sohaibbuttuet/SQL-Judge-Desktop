using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Leaderboard
    {
        public int LeaderboardID { get; set; }
        public int StudentID { get; set; }   // FK → Students
        public int ContestID { get; set; }   // FK → Contests
        public int TotalSolved { get; set; } = 0;
        public int TotalScore { get; set; } = 0;

        public Leaderboard(int leaderboardID, int studentID, int contestID, int totalSolved, int totalScore)
        {
            LeaderboardID = leaderboardID;
            StudentID = studentID;
            ContestID = contestID;
            TotalSolved = totalSolved;
            TotalScore = totalScore;
        }
    }
}
