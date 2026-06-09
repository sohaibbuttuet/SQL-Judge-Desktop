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
        public static void AddContestParticipent(ContestParticipant p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p), "ContestParticipent cannot be null.");
  
            if (p.ContestID <= 0)
                throw new ArgumentException("ContestId must be a positive integer.", nameof(p.ContestID));

            if (p.StudentID <= 0)
                throw new ArgumentException("StudentId must be a positive integer.", nameof(p.StudentID));

            if (ContestParticipantsDL.IsParticpantAlreadyJoined(p.ContestID, p.StudentID))
                throw new ArgumentException("You have already joined this contest.");

            ContestParticipantsDL.AddContestParticipent(p);
        }
        public static bool IsParticipantRegistered(ContestParticipant p)
        {
            if (p == null)
                throw new ArgumentNullException(nameof(p), "ContestParticipent cannot be null.");

            if (p.ContestID <= 0)
                throw new ArgumentException("ContestId must be a positive integer.", nameof(p.ContestID));

            if (p.StudentID <= 0)
                throw new ArgumentException("StudentId must be a positive integer.", nameof(p.StudentID));

            if (ContestParticipantsDL.IsParticpantAlreadyJoined(p.ContestID, p.StudentID))
                return true;

            return false;
        }

        public static bool IsContestFullySolved(int studentID, int contestID)
        {
            VerifyData(studentID, contestID);

            int contestProblems = ContestProblemsDL.CountContestProblems(contestID);
            int submittedProblems = SubmissionDL.SubmittedContestProblems(studentID, contestID);

            if (contestProblems == submittedProblems) return true;
            return false;
        }
        public static bool IsContestPartiallyPassed(int studentID, int contestID)
        {
            VerifyData(studentID, contestID);

            int contestProblems = ContestProblemsDL.CountContestProblems(contestID);
            int submittedProblems = SubmissionDL.SubmittedContestProblems(studentID, contestID);

            if (contestProblems > submittedProblems) return true;
            return false;
        }
        private static void VerifyData(int studentID, int contestID)
        {
            if (studentID <= 0)
                throw new ArgumentOutOfRangeException(nameof(studentID), "Invalid Student ID");
            if (contestID <= 0)
                throw new ArgumentOutOfRangeException(nameof(studentID), "Invalid Contest ID");
        }

        // For Contest Panel in Admin Dashboard
        public static DataTable GetContests()
        {
            return ContestDL.GetAllContests();
        }

        // Report
        public static DataTable GetContestRanking(int limit)
        {
            if (limit <= 0)
            {
                return new DataTable(); // Return a clean empty table layout structural baseline
            }

            return ContestDL.GetContestRanking(limit);
        }
    }
}
