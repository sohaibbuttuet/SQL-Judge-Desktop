using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestParticipent 
    {
        public int ContestId { get; set; }
        public int StudentId { get; set; }
        public DateTime JoinedAt { get; set; }

        public ContestParticipent() { }
        public ContestParticipent(int contestId, int studentId)
        {
            ContestId = contestId;
            StudentId = studentId;
        }
    }
}
