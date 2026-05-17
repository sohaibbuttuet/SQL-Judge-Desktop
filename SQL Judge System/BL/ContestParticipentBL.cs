using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;
using SQL_Judge_System.DL;

namespace SQL_Judge_System.BL
{
    internal class ContestParticipentBL
    {
        public static void AddContestParticipent(ContestParticipant contestParticipent)
        {
            if(contestParticipent == null)
            {
                throw new ArgumentNullException(nameof(contestParticipent), "ContestParticipent cannot be null.");
            }
            if(contestParticipent.ContestId <= 0)
            {
                throw new ArgumentException("ContestId must be a positive integer.", nameof(contestParticipent.ContestId));
            }
            if(contestParticipent.StudentId <= 0)
            {
                throw new ArgumentException("StudentId must be a positive integer.", nameof(contestParticipent.StudentId));
            }
            ContestParticipentDL.AddContestParticipent(contestParticipent);
        }
    }
}
