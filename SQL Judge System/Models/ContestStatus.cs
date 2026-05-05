using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public ContestStatus()
        {
        }
        public ContestStatus(int statusID, string statusName)
        {
            StatusID = statusID;
            StatusName = statusName;
        }
    }
}
