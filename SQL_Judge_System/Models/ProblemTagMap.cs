using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemTagMap
    {
        private int problemID;
        private int tagID;

        public int ProblemID
        {
            get { return problemID; }
            set 
            {
                if(value <=  0)
                    throw new ArgumentOutOfRangeException("value");

                problemID = value; 
            }
        }
        public int TagID
        {
            get { return tagID; }
            set 
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException("value");

                tagID = value;
            }
        }

        public ProblemTagMap()
        {
        }
        public ProblemTagMap(int problemID, int tagID)
        {
            ProblemID = problemID;
            TagID = tagID;
        }   
    }
}
