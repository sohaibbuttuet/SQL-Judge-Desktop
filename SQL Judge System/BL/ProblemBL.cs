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
        // ==========================================
        // CORE CRUD OPERATIONS
        // ==========================================
        public static void AddProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");

            if (ProblemDL.IsProblemExists(problem.Title, problem.DifficultyID))
                throw new ArgumentException("Problem with the same title and difficulty already exists.");

            problem.ProblemID = ProblemDL.AddProblem(problem);
        }
        public static void UpdateProblem(Problem problem)
        {
            if (problem == null)
                throw new ArgumentNullException(nameof(problem), "Problem cannot be null.");

            if (ProblemDL.IsProblemExists(problem.ProblemID, problem.Title, problem.DifficultyID))
                throw new ArgumentException("Another problem with the same title and difficulty already exists.");

            ProblemDL.UpdateProblem(problem);
        }

        // ==========================================
        // PROBLEM STATUS MANAGEMENT
        // ==========================================
        public static void ActivateProblem(int problemId)
        {
            ValidateProblemId(problemId);
            ProblemDL.ActivateProblem(problemId);
        }
        public static void DeactivateProblem(int problemId)
        {
            ValidateProblemId(problemId);
            ProblemDL.DeactivateProblem(problemId);
        }
        private static void ValidateProblemId(int problemId)
        {
            if (problemId <= 0)
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be a positive integer.");

            if (!ProblemDL.IsProblemExists(problemId))
                throw new InvalidOperationException("The requested problem does not exist.");
        }

        // ==========================================
        // ADMIN DASHBOARD DATA VIEWS
        // ==========================================
        public static DataTable ProblemsList()
        {
            return ProblemDL.ProblemsList();
        }
        public static List<Problem> GetProblems()
        {
            return ProblemDL.GetProblems();
        }
        public static DataTable GetContestProblems(int contestID)
        {
            if (contestID <= 0)
                throw new ArgumentException("Invalid Contest ID specified.", nameof(contestID));

            return ProblemDL.GetContestProblems(contestID);
        }

        // ==========================================
        // STUDENT DASHBOARD PROBLEM MATCHERS
        // ==========================================
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
        public static Problem GetProblemByID(int problemId)
        {
            if (problemId <= 0)
                throw new ArgumentOutOfRangeException(nameof(problemId), "Problem ID must be greater than 0.");

            return ProblemDL.GetProblemByID(problemId);
        }

        // ==========================================
        // SYSTEM ANALYTICS COUNTERS
        // ==========================================
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

        // ==========================================
        // LOOKUP DATA
        // ==========================================
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

        // ==========================================
        // JUNCTION RELATION MAPS (MANY-TO-MANY)
        // ==========================================
        public static void MapProblemTag(ProblemTagMap pt)
        {
            if (pt == null)
                throw new ArgumentNullException(nameof(pt), "ProblemTagMap object cannot be null.");

            if (pt.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            if (pt.TagID <= 0)
                throw new ArgumentException("Invalid Tag ID.");

            ProblemTagMapDL.MapProblemTag(pt);
        }
        public static void DeleteTagsByProblemID(int problemID)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");
            
            ProblemTagMapDL.DeleteByProblemID(problemID);
        }

        // ==========================================
        // VALIDATION SCHEMAS & ACCESSED TABLES
        // ==========================================
        public static void SaveCheckedTables(int problemID, List<string> selectedTables)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            if (selectedTables == null) return;

            foreach (string tableName in selectedTables)
            {
                if (!string.IsNullOrWhiteSpace(tableName))
                {
                    ProblemTable table = new ProblemTable
                    {
                        ProblemID = problemID,
                        TableName = tableName.Trim()
                    };
                    ProblemTablesDL.AddProblemTable(table);
                }
            }
        }
        public static void DeleteCheckedTables(int problemID)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            ProblemTablesDL.DeleteAllByProblemID(problemID);
        }
        public static List<ProblemTable> GetSelectedTablesByProblemID(int problemID)
        {
            if (problemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            return ProblemTablesDL.GetTablesByProblemID(problemID);
        }
    }
}