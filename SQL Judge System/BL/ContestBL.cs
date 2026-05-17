using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Judge_System.BL
{
    internal class ContestBL
    {
        public static void CreateContest(Contest contest)
        {
            if (contest == null)
            {
                throw new ArgumentNullException(nameof(contest), "Contest cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(contest.Title))
            {
                throw new ArgumentException("Contest title cannot be empty.");
            }
            if (contest.StartDate >= contest.EndDate)
            {
                throw new ArgumentException("Contest start date must be before end date.");
            }
            if (contest.CreatedBy <= 0)
            {
                throw new ArgumentException("Invalid creator ID.");
            }
            if (contest.Description.Length > 1000)
            {
                throw new ArgumentException("Contest description cannot exceed 1000 characters.");
            }
            if (IsContestExists(contest.Title))
            {
                throw new ArgumentException("Contest already exists.");
            }

            ContestDL.CreateContest(contest);
        }
        public static void UpdateContest(Contest contest, int currentUserID)
        {
            if (contest == null)
            {
                throw new ArgumentNullException(nameof(contest), "Contest cannot be null.");
            }
            if (contest.ContestID <= 0)
            {
                throw new ArgumentException("Invalid Contest ID.");
            }
            if (contest.CreatedBy <= 0)
            {
                throw new ArgumentException("Invalid creator ID.");
            }
            if (contest.CreatedBy != currentUserID)
            {
                throw new UnauthorizedAccessException("You are not allowed to update this contest.");
            }
            if (contest.EndDate <= contest.StartDate)
            {
                throw new ArgumentException("End date must be greater than start date.");
            }
            if (contest.Description.Length > 1000)
            {
                throw new ArgumentException("Contest description cannot exceed 1000 characters.");
            }
            if (IsContestExists(contest.ContestID, contest.Title))
            {
                throw new ArgumentException("Contest title already exists.");
            }
            ContestDL.UpdateContest(contest);
        }
        public static bool IsContestExists(string Title)
        {
            return ContestDL.IsContestExists(Title);
        }
        public static bool IsContestExists(int contestID, string Title)
        {
            return ContestDL.IsContestExists(contestID, Title);
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
