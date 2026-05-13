using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestParticipant
    {
        public int ContestId { get; set; }
        public int StudentId { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.Now;

        public ContestParticipant() { }
        public ContestParticipant(int contestId, int studentId, DateTime joinedAt)
        {
            ContestId = contestId;
            StudentId = studentId;
            JoinedAt = joinedAt;
        }
    }
}
