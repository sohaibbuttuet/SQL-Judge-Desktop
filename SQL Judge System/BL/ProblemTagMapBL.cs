using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.BL
{
    internal class ProblemTagMapBL
    {
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
