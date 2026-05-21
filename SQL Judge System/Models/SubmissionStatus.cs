using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class SubmissionStatus
    {
        private int statusId;
        private string statusName;  

        public int StatusId
        {
            get { return statusId; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("StatusId cannot be negative.");
                }
                statusId = value;
            }
        }
        public string StatusName
        {
            get { return statusName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("StatusName cannot be null or empty.");
                }
                statusName = value;
            }
        }

        public SubmissionStatus() { }
        public SubmissionStatus(int statusId, string statusName)
        {
            StatusId = statusId;
            StatusName = statusName;
        }
    }
}
