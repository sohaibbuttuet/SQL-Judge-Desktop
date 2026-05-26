using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.DL;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.BL
{
    internal class SubmissionBL
    {        
        public static void AddSubmission(Submission submission)
        {
            submission.SubmissionID = SubmissionDL.AddSubmission(submission);
        }


        // Submission Panel in Admin Dashboard
        public static DataTable GetSubmissions()
        {
            return SubmissionDL.GetSubmissionsForAdmin();
        }
        public static int TotalSubmissions()
        {
            return SubmissionDL.TotalSubmissions();
        }
        public static int AcceptedSubmissions()
        {
            return SubmissionDL.AcceptedSubmissions();
        }
        public static int RejectedSubmissions()
        {
            return SubmissionDL.RejectedSubmissions();
        }
    }
}
