using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.LookupDL;

namespace SQL_Judge_System.BL
{
    internal class ProblemTagsBL
    {
        public static DataTable GetAllTags()
        {
            return ProblemTagsDL.GetAll();
        }
    }
}
