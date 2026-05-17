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
        public int CreatedBy { get; set; }   // FK → Users

        public Contest() { }
        public Contest(string title, string description, DateTime startDate, DateTime endDate, int createdBy)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;
        }
        public Contest(int contestId, string title, string description, DateTime startDate, DateTime endDate, int createdBy)
        {
            ContestID = contestId;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            CreatedBy = createdBy;
        }

    }
}
