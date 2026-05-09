using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;

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
        public static void UpdateProblemStatus(int problemID, bool isActive)
        {
            ProblemDL.UpdateProblemStatus(problemID, isActive);
        }
    }
}
