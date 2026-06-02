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
            ValidateContest(contest); // internally throws exceptions if validation fails

            if (ContestDL.IsContestExists(contest.Title))
                throw new ArgumentException("Contest already exists.");

            contest.ContestID = ContestDL.CreateContest(contest);
        }
        public static void UpdateContest(Contest contest)
        {
            ValidateContest(contest); // internally throws exceptions if validation fails

            if (ContestDL.IsContestExists(contest.ContestID, contest.Title))
                throw new ArgumentException("Contest title already exists.");          

            ContestDL.UpdateContest(contest);
        }
        private static void ValidateContest(Contest contest)
        {
            if (contest == null)
                throw new ArgumentNullException(nameof(contest), "Contest cannot be null.");
            if (contest.StartDate >= contest.EndDate)
                throw new ArgumentException("Contest start date must be before end date.");
            if (contest.Description.Length > 1000)
                throw new ArgumentException("Contest description cannot exceed 1000 characters.");
        }

        public static Contest GetContestByID(int contestID)
        {
            if (contestID <= 0)
                throw new ArgumentException("Invalid Contest ID");

            return ContestDL.GetContestByID(contestID);
        }

        // Managing Contest Problems
        public static void AddProblem(ContestProblem contestProblem)
        {
            if(contestProblem.ContestID <= 0)
                throw new ArgumentException("Invalid Contest ID");

            if (contestProblem.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            if (ContestProblemsDL.IsProblemExistsinContest(contestProblem))
                throw new Exception("Problem already exists;");

            ContestProblemsDL.AddProblem(contestProblem);
        }
        public static void RemoveProblem(ContestProblem contestProblem)
        {
            if (contestProblem.ContestID <= 0)
                throw new ArgumentException("Invalid Contest ID");

            if (contestProblem.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            if (!ContestProblemsDL.IsProblemExistsinContest(contestProblem))
                throw new Exception("Problem does not exist;");

            ContestProblemsDL.DeleteProblem(contestProblem);
        }
        public static void DeleteProblemsByContestID(int contestID)
        {
            if (contestID <= 0)
                throw new ArgumentException("Invalid Contest ID");

            if (!ContestProblemsDL.IsContestExists(contestID))
                throw new Exception("Contest does not exists.");

            ContestProblemsDL.DeleteProblemsByContestID(contestID);
        }
        public static List<ContestProblem> GetProblemsByContestID(int contestID)
        {
            if (contestID <= 0)
                throw new ArgumentException("Invalid Problem ID");

            return ContestProblemsDL.GetProblemsByContestID(contestID);
        }

        // Managing Contest Participents
        public static void AddContestParticipent(ContestParticipant contestParticipent)
        {
            if (contestParticipent == null)
                throw new ArgumentNullException(nameof(contestParticipent), "ContestParticipent cannot be null.");
  
            if (contestParticipent.ContestId <= 0)
                throw new ArgumentException("ContestId must be a positive integer.", nameof(contestParticipent.ContestId));

            if (contestParticipent.StudentId <= 0)
                throw new ArgumentException("StudentId must be a positive integer.", nameof(contestParticipent.StudentId));

            ContestParticipentsDL.AddContestParticipent(contestParticipent);
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
