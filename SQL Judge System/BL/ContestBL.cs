using SQL_Judge_System.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.BL
{
    internal class ContestBL
    {
        public static void CreateContest(Contest contest)
        {
            if(contest == null)
            {
                throw new ArgumentNullException(nameof(contest), "Contest cannot be null.");
            }
            if(string.IsNullOrWhiteSpace(contest.Title))
            {
                throw new ArgumentException("Contest title cannot be empty.", nameof(contest.Title));
            }
            if(contest.StartDate >= contest.EndDate)
            {
                throw new ArgumentException("Contest start date must be before end date.");
            }
            if(contest.CreatedBy <= 0)
            {
                throw new ArgumentException("CreatedBy must be a valid user ID.", nameof(contest.CreatedBy));
            }
            if(contest.Description == null)
            {
                contest.Description = string.Empty; // Set to empty string if null
            }
            if(contest.Description.Length > 1000)
            {
                throw new ArgumentException("Contest description cannot exceed 1000 characters.", nameof(contest.Description));
            }
            ContestDL.CreateContest(contest);
        }
        public static void UpdateContest(Contest contest)
        {
            if (contest == null)
            {
                throw new ArgumentNullException(nameof(contest), "Contest cannot be null.");
            }
            if (contest.ContestID <= 0)
            {
                throw new ArgumentException("Contest ID must be a positive integer.", nameof(contest.ContestID));
            }
            if (string.IsNullOrWhiteSpace(contest.Title))
            {
                throw new ArgumentException("Contest title cannot be empty.", nameof(contest.Title));
            }
            if (contest.StartDate >= contest.EndDate)
            {
                throw new ArgumentException("Contest start date must be before end date.");
            }
            if (contest.CreatedBy <= 0)
            {
                throw new ArgumentException("CreatedBy must be a valid user ID.", nameof(contest.CreatedBy));
            }
            if (contest.Description == null)
            {
                contest.Description = string.Empty; // Set to empty string if null
            }
            if (contest.Description.Length > 1000)
            {
                throw new ArgumentException("Contest description cannot exceed 1000 characters.", nameof(contest.Description));
            }
            ContestDL.UpdateContest(contest);
        }

        public static DataTable GetContests()
        {
            return ContestDL.GetAllContests();
        }
        public static int TotalContests()
        {
            return ContestDL.TotalContests();
        }
        public static int ActiveContests()
        {
            return ContestDL.ActiveContests();
        }
        public static int InactiveContests()
        {
            return ContestDL.InactiveContests();
        }
        public static int UpcomingContests()
        {
            return ContestDL.UpcomingContests();
        }
    }
}
