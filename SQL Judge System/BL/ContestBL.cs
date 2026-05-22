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
            if (contest.StartDate >= contest.EndDate)
            {
                throw new ArgumentException("Contest start date must be before end date.");
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
            if (IsContestExists(contest.ContestID, contest.Title))
            {
                throw new ArgumentException("Contest title already exists.");
            }
            if (contest.EndDate <= contest.StartDate)
            {
                throw new ArgumentException("End date must be greater than start date.");
            }
            if (contest.Description.Length > 1000)
            {
                throw new ArgumentException("Contest description cannot exceed 1000 characters.");
            }
            if (contest.CreatedBy != currentUserID)
            {
                throw new UnauthorizedAccessException("You are not allowed to update this contest.");
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

        // For Contest Panel in Admin Dashboard
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
