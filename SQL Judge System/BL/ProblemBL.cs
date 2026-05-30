using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
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
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");

            if (ProblemDL.IsProblemExists(problem.Title, problem.DifficultyID))
                throw new ArgumentException("Problem already exists.");                

            problem.ProblemID = ProblemDL.AddProblem(problem);
        }
        public static void UpdateProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");

            if (ProblemDL.IsProblemExists(problem.ProblemID, problem.Title, problem.DifficultyID))
                throw new ArgumentException("Problem already exists.");

            ProblemDL.UpdateProblem(problem);
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

        // Problem Panel in Admin Dashboard
        public static DataTable ProblemsList()
        {
            return ProblemDL.ProblemsList();
        }
        public static List<Problem> GetProblems()
        {
            return ProblemDL.GetProblems();
        }

        // Student Panel Problems
        public static DataTable GetAllProblems()
        {
            return ProblemDL.AllProblemsList();
        }
        public static DataTable GetEasyProblems()
        {
            return ProblemDL.EasyProblemsList();
        }
        public static DataTable GetMediumProblems()
        {
            return ProblemDL.MediumProblemsList();
        }
        public static DataTable GetHardProblems()
        {
            return ProblemDL.HardProblemsList();
        }
        public static string GetDescriptionByID(int problemID)
        {
            if (problemID < 0)
                throw new ArgumentOutOfRangeException(nameof(problemID), "Invalid Problem ID");

           return ProblemDL.GetDescriptionByID(problemID);
        }

        public static Problem GetProblemByID(int problemId)
        {
            if (problemId <= 0)
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be greater than 0.");

            return ProblemDL.GetProblemByID(problemId);
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

        // For Problem lookups
        public static List<ProblemDifficulty> GetProblemDifficulties()
        {
            return ProblemDifficultiesDL.GetProblemDifficulties();
        }
        public static List<ProblemTag> GetProblemTags()
        {
            return ProblemTagsDL.GetProblemTags();
        }
        public static List<ProblemTagMap> GetProblemTags(int problemId)
        {
            if (problemId <= 0)
                throw new ArgumentOutOfRangeException(nameof(problemId), "Invalid Problem ID");

            return ProblemTagMapDL.GetProblemTags(problemId);
        }

        // For Problem Junction Tables
        public static void MapProblemTag(ProblemTagMap pt)
        {
            if (pt == null)
            {
                throw new ArgumentNullException(nameof(pt), "ProblemTagMap object cannot be null.");
            }

            if (pt.ProblemID <= 0)
            {
                throw new ArgumentException("Invalid Problem ID.");
            }

            if (pt.TagID <= 0)
            {
                throw new ArgumentException("Invalid Tag ID.");
            }

            ProblemTagMapDL.MapProblemTag(pt);
        }
        public static void DeleteByProblemID(int problemID)
        {
            if (problemID <= 0)
            {
                throw new ArgumentException("Invalid Problem ID.");
            }
            ProblemTagMapDL.DeleteByProblemID(problemID);
        }
    }
}
