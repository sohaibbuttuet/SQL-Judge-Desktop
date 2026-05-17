using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class ProblemBL
    {
        public static void AddProblem(Problem problem)
        {
            if(problem == null)
            {
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");
            }
            problem.ProblemID = ProblemDL.AddProblem(problem);
        }
        public static void UpdateProblem(Problem problem)
        {
            if (problem == null)
            {
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");
            }
            ProblemDL.UpdateProblem(problem);
        }
        public static bool IsProblemExists(string title, int difficultyID)
        {
            return ProblemDL.IsProblemExists(title, difficultyID);
        }
        public static void ActivateProblem(int problemId)
        {
            if (problemId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be a non-negative integer.");
            }
            if (!ProblemDL.IsProblemExists(problemId))
            {
                throw new InvalidOperationException("Problem does not exist.");
            }
            ProblemDL.ActivateProblem(problemId);
        }
        public static void DeactivateProblem(int problemId)
        {
            if (problemId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be a non-negative integer.");
            }
            if (!ProblemDL.IsProblemExists(problemId))
            {
                throw new InvalidOperationException("Problem does not exist.");
            }
            ProblemDL.DeactivateProblem(problemId);
        }
        public static int TotalProblems()
        {
            return ProblemDL.TotalProblems();
        }
        public static int ActiveProblems()
        {
            return ProblemDL.ActiveProblems();
        }
        public static int InactiveProblems()
        {
            return ProblemDL.InactiveProblems();
        }
        public static DataTable ProblemsList()
        {
            return ProblemDL.ProblemsList();
        }    
    }
}
