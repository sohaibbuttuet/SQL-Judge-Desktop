using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using SQL_Judge_System.DL;
using SQL_Judge_System.LookupDL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class SubmissionBL
    {
        public static void CreateSubmission(Submission submission)
        {
            if (submission == null)
                throw new ArgumentException("Submission cannot be null.");

            if (submission.ProblemID <= 0)
                throw new ArgumentException("Invalid Problem ID.");

            if (submission.StudentID <= 0)
                throw new ArgumentException("Invalid StudentID.");

            // This will throw an ArgumentException and stop execution if malicious text is found.
            submission.QueryText = QueryRunnerBL.CleanAndValidateQuery(submission.QueryText);

            // 1. Save submission record FIRST to get the Auto-Incremented SubmissionID
            submission.SubmissionID = SubmissionDL.AddSubmission(submission);
        }
        private static bool CompareTables(DataTable expected, DataTable student, out string mismatchReason)
        {
            mismatchReason = "";

            if (expected.Rows.Count != student.Rows.Count)
            {
                mismatchReason = $"Row count mismatch. Expected: {expected.Rows.Count}, Got: {student.Rows.Count}.";
                return false;
            }

            if (expected.Columns.Count != student.Columns.Count)
            {
                mismatchReason = $"Column count mismatch. Expected: {expected.Columns.Count}, Got: {student.Columns.Count}.";
                return false;
            }

            for (int i = 0; i < expected.Rows.Count; i++)
            {
                for (int j = 0; j < expected.Columns.Count; j++)
                {
                    if (expected.Rows[i][j]?.ToString() != student.Rows[i][j]?.ToString())
                    {
                        mismatchReason = $"Data mismatch at Row {i + 1}, Column '{expected.Columns[j].ColumnName}'.";
                        return false;
                    }
                }
            }

            return true;
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
