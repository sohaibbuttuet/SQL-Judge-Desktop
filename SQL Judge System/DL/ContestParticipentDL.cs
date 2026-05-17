using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class ContestParticipentDL
    {
        public static void AddContestParticipent(ContestParticipant contestParticipent)
        {
            string query = $"INSERT INTO ContestParticipent (ContestId, UserId, JoinedAt) VALUES ({contestParticipent.ContestId}, {contestParticipent.StudentId}, '{contestParticipent.JoinedAt:yyyy-MM-dd HH:mm:ss}')";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
