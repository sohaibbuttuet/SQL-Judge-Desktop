using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemTagMap
    {
        public int ProblemID { get; set; }
        public int TagID { get; set; }
        public ProblemTagMap(int problemID, int tagID)
        {
            ProblemID = problemID;
            TagID = tagID;
        }   
    }
}
