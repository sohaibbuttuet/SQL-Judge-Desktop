using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.DL
{
    internal class ContestParticipantsDL
    {
        public static void AddContestParticipent(ContestParticipant p)
        {
            string query = "INSERT INTO ContestParticipants (ContestID, StudentID) VALUES (@ContestID, @StudentID);";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@ContestID", p.ContestID),
                 new MySqlParameter("@StudentID", p.StudentID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
        public static bool IsParticpantAlreadyJoined(int contestID, int studentID)
        {
            string query = "SELECT COUNT(1) FROM ContestParticipants WHERE ContestID = @ContestID AND StudentID = @StudentID;";

            MySqlParameter[] paramaters =
            {
                new MySqlParameter("@ContestID", contestID),
                new MySqlParameter("@StudentID" ,studentID)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, paramaters) > 0;
        }
    }
}
