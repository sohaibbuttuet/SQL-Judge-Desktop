using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.Models
{
    internal class ContestParticipant 
    {
        private int contestID;
        private int studentID;
        private DateTime joinedAt;

        public int ContestID
        {
            get { return contestID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Contest ID.");

                contestID = value;
            }
        }
        public int StudentID
        {
            get { return studentID; }
            set
            {
                if (value <= 0)
                    throw new Exception("Invalid Student ID.");

                studentID = value;
            }
        }
        public DateTime JoinedAt
        {
            get { return joinedAt; }
            set { joinedAt = value; }
        }

        public ContestParticipant() { }
        public ContestParticipant(int contestID, int studentID)
        {
            ContestID = contestID;
            StudentID = studentID;
            JoinedAt = DateTime.Now;
        }
    }
}
