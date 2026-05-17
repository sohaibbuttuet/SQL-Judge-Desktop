using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.LookupDL;

namespace SQL_Judge_System.BL
{
    internal class ProblemDifficultyBL
    {
        public static DataTable GetAll()
        {
            return ProblemDifficultyDL.GetAll();
        }
    }
}
