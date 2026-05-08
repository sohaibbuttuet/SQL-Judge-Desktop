using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestProblem
    {
        // Primary key is composite: (ContestID, ProblemID)
        public int ContestID { get; set; }
        public int ProblemID { get; set; }
        public int OrderNumber { get; set; }   // Controls display order in the contest

        public ContestProblem() { }
        public ContestProblem(int contestID, int problemID, int orderNumber)
        {
            ContestID = contestID;
            ProblemID = problemID;
            OrderNumber = orderNumber;
        }
    }
}
