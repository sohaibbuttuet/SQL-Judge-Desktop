using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SQL_Judge_System.Models;

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
        public static Student GetStudentByID(int studentID)
        {
            string query = "SELECT * FROM Students WHERE StudentID = @StudentID;";
            MySqlParameter[] parameters = { new MySqlParameter("@StudentID", studentID) };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt == null || dt.Rows.Count == 0)
                return null;

            return MapDataRowToStudent(dt.Rows[0]);
        }
        public static List<Student> GetAllStudents()
        {
            string query = "SELECT * FROM Students;";

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Student> students = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                students.Add(MapDataRowToStudent(row));
            }
            return students;
        }
        public static List<Student> GetTopStudents(int limit)
        {
            string query = "SELECT * FROM Students ORDER BY TotalScore DESC LIMIT @Limit;";
            MySqlParameter[] parameters = { new MySqlParameter("@Limit", limit) };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);
            List<Student> list = new List<Student>();

            foreach (DataRow row in dt.Rows)
                list.Add(MapDataRowToStudent(row));

            return list;
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
        // ADMIN MANAGEMENT PANEL ANALYTICS
        // ==========================================
        public static DataTable GetStudents()
        {
            string query = "SELECT * FROM vw_students ORDER BY StudentID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        // ==========================================
        // STUDENT MANAGEMENT PANEL ANALYTICS
        // ==========================================
        public static DataTable GetLeaderboard()
        {
            string query = "SELECT * FROM vw_students_leaderboard;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static int GetRank(int studentId)
        {
            string query = $"SELECT GlobalRank FROM vw_students_leaderboard WHERE StudentID = @StudnetID;";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@StudnetID", studentId)
            };

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
        }
    }
} 