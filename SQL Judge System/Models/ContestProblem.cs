using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestProblem
    {
        private int contestID;
        private int problemID;

        public int ContestID
        {
            get { return contestID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Contest ID.");

                contestID = value;
            }
        }
        public int ProblemID
        {
            get { return problemID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Problem ID.");

                problemID = value;
            }
        }

        public ContestProblem() { }
        public ContestProblem(int contestID, int problemID)
        {
            ContestID = contestID;
            ProblemID = problemID;
        }
    }
}
