using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class LookupBase
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public LookupBase(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
