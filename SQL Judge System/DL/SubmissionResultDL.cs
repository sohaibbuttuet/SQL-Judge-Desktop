using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.DL
{
    internal class SubmissionResultDL
    {
        public static void AddResult(SubmissionResult result)
        {
            string query = "INSERT INTO submissionResults (SubmissionID, IsPassed, ErrorMessage) " +
                           "VALUES (@SubmissionID, @IsPassed, @ErrorMessage);";

            MySqlParameter[] parameters = 
            {
                new MySqlParameter("@SubmissionID", result.SubmissionID),
                new MySqlParameter("@IsPassed", result.IsPassed ? 1 : 0), 
                new MySqlParameter("@ErrorMessage", string.IsNullOrEmpty(result.ErrorMessage) ? DBNull.Value : (object)result.ErrorMessage) // Handles null values cleanly if there is no error
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }
    }
}
