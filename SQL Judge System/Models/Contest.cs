using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class Contest
    {
        public int ContestID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusID { get; set; }   // FK → ContestStatus
        public int CreatedBy { get; set; }   // FK → Users

        public Contest() { }
        public Contest(int contestID, string title, string description, DateTime startDate, DateTime endDate, int statusID, int createdBy)
        {
            ContestID = contestID;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            StatusID = statusID;
            CreatedBy = createdBy;
        }
    }
}
