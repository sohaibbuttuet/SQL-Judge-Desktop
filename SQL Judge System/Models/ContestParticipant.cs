using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestParticipant 
    {
        private int contestId;
        private int studentId;
        private DateTime joinedAt;

        public int ContestId
        {
            get { return contestId; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Contest ID.");

                contestId = value;
            }
        }
        public int StudentId
        {
            get { return studentId; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Student ID.");

                studentId = value;
            }
        }
        public DateTime JoinedAt
        {
            get { return joinedAt; }
            set { joinedAt = value; }
        }

        public ContestParticipant() { }
        public ContestParticipant(int contestId, int studentId)
        {
            ContestId = contestId;
            StudentId = studentId;
            JoinedAt = DateTime.Now;
        }
    }
}
