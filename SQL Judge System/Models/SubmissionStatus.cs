using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SubmissionStatus
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public SubmissionStatus() { }
        public SubmissionStatus(int statusID, string statusName)
        {
            StatusID = statusID;
            StatusName = statusName;
        }
    }
}
