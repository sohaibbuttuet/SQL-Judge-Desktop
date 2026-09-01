using System;
using System.Data;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.BL
{
    internal class ReportsBL
    {
        // =========================
        // ADMIN DASHBOARD METRICS
        // =========================
        public static DataTable GetStudentMetrics(DateTime startDate, DateTime endDate)
        {
            // basic validation
            if (startDate > endDate)
                throw new Exception("Start date cannot be greater than end date.");

            DataTable dt = ReportsDL.StudentMetrices(startDate, endDate);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }

        // =========================
        // STUDENT PERFORMANCE METRICS
        // =========================
        public static DataTable GetStudentSubmissionMetrics(int studentID, DateTime startDate, DateTime endDate)
        {
            // validation
            if (studentID <= 0)
                throw new Exception("Invalid Student ID.");

            if (startDate > endDate)
                throw new Exception("Start date cannot be greater than end date.");

            DataTable dt = ReportsDL.StudentSubmissionMetrices(studentID, startDate, endDate);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }

        // =========================
        // SUBMISSIONS METRICS
        // =========================
        public static DataTable GetSubmissionMetrics(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new Exception("Start date cannot be greater than end date.");

            DataTable dt = ReportsDL.GetSubmissionMetrics(startDate, endDate);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }

        // =========================
        // Contest METRICS
        // =========================
        public static DataTable ContestMetrics(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new Exception("Start date cannot be greater than end date.");

            DataTable dt = ReportsDL.ContestMetrics(startDate, endDate);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return dt;
        }
        public static DataTable ContestCompletionRate(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
                throw new Exception("Start date cannot be greater than end date.");

            return ReportsDL.ContestCompletionRate(startDate, endDate);
        }
    }
}