using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;
using SQL_Judge_System.Helper;

namespace SQL_Judge_System.DL
{
    internal class StudentDL
    {
        // ==========================================
        // CREATE / INSERT REGISTRATION DATA
        // ==========================================
        public static int AddStudent(Student student)
        {
            string query = "INSERT INTO Students (UserID, RegistrationNumber, SkillLevelID, TotalScore, ProblemsSolved) " +
                           "VALUES (@UserID, @RegistrationNumber, @SkillLevelID, @TotalScore, @ProblemsSolved); " +
                           "SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@UserID", student.UserID),
        new MySqlParameter("@RegistrationNumber", student.RegistrationNumber),
        new MySqlParameter("@SkillLevelID", student.SkillLevelID),
        new MySqlParameter("@TotalScore", student.TotalScore),
        new MySqlParameter("@ProblemsSolved", student.ProblemsSolved)
    };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters);
        }

        // ==========================================
        // UPDATE PROFILE CHANGES
        // ==========================================
        public static void UpdateStudent(Student student)
        {
            string query = "UPDATE Students SET RegistrationNumber = @RegistrationNumber, SkillLevelID = @SkillLevelID WHERE StudentID = @StudentID;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@RegistrationNumber", student.RegistrationNumber),
        new MySqlParameter("@SkillLevelID", student.SkillLevelID),
        new MySqlParameter("@StudentID", student.StudentID)
            };

            DatabaseHelper.Instance.Update(query, parameters);
        }


        // ==========================================
        // DATA ACCESS 
        // ==========================================
        public static Student GetStudentByUserID(int userID)
        {
            string query = "SELECT * FROM Students WHERE UserID = @UserID;";
            MySqlParameter[] parameters = { new MySqlParameter("@UserID", userID) };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return MapDataRowToStudent(dt.Rows[0]);
        }

        // ==========================================
        // HELPER FUNCTIONS
        // ==========================================
        private static Student MapDataRowToStudent(DataRow row)
        {
            return new Student(
                Convert.ToInt32(row["StudentID"]),
                Convert.ToInt32(row["UserID"]),
                row["RegistrationNumber"].ToString(),
                Convert.ToInt32(row["TotalScore"]),
                Convert.ToInt32(row["ProblemsSolved"]),
                 Convert.ToInt32(row["SkillLevelID"])
            );
        }

        // ==========================================
        // SYSTEM UNIQUE ENTITY ACCOUNT CHECKERS
        // ==========================================
        public static bool IsStudentExist(string regno)
        {
            string query = "SELECT COUNT(1) FROM Students WHERE RegistrationNumber = @regno;";

            MySqlParameter[] parameters =
            {
                 new MySqlParameter("@regno", regno)
            };

            return DatabaseHelper.Instance.ExecuteScalar(query, parameters) > 0;
        }
        public static bool IsStudentExist(int studentID, string regno)
        {
            string query = "SELECT COUNT(1) FROM Students WHERE RegistrationNumber = @regno AND StudentID <> @StudentID;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@regno", regno),
        new MySqlParameter("@StudentID", studentID)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }

        // ==========================================
        // ADMIN/Student MANAGEMENT PANEL ANALYTICS
        // ==========================================
        public static DataTable GetStudents()
        {
            string query = "SELECT * FROM vw_students;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable GetTopStudents(int limit, DateTime startDate, DateTime endDate)
        {
            // Combines chronological filtering, leaderboard ordering, and top-tier row truncation
            string query = @"SELECT GlobalRank, FullName AS StudentName, RegistrationNumber, LevelName, TotalScore FROM vw_students 
                     WHERE CreatedAt >= @StartDate 
                       AND CreatedAt <= @EndDate      
                     LIMIT @Limit;";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@Limit", limit),
        new MySqlParameter("@StartDate", startDate),
        new MySqlParameter("@EndDate", endDate)
    };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
        public static int GetRank(int studentId)
        {
            string query = $"SELECT GlobalRank FROM vw_students WHERE StudentID = @StudnetID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudnetID", studentId)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
        }
    }
} 