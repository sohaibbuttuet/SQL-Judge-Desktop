using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ProblemDifficulty : LookupBase
    {
        public ProblemDifficulty(int id): base(id)
        {

        }
        public ProblemDifficulty(int id, string name) : base(id, name)
        {

        }
    }
}
