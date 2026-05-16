using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class StudentDL
    {
        public static int AddStudent(Student student)
        {
            string query = $"INSERT INTO Students (UserID, RegistrationNumber, SkillLevelID, TotalScore, ProblemsSolved) " +
                           $"VALUES ({student.UserID}, '{student.RegistrationNumber}', {student.SkillLevelID}, {student.TotalScore}, {student.ProblemsSolved}); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateStudent(Student student)
        {
            string query = $"UPDATE Students SET RegistrationNumber = '{student.RegistrationNumber}', SkillLevelID = {student.SkillLevelID}, TotalScore = {student.TotalScore}, ProblemsSolved = {student.ProblemsSolved} " +
                           $"WHERE StudentID = {student.StudentID};";
            DatabaseHelper.Instance.Update(query);
        }
        public static void UpdateStudentRecord(int studentId, int score, int solved)
        {
            string query = $"UPDATE Students SET TotalScore = {score}, ProblemsSolved = {solved} WHERE StudentID = {studentId}";
            DatabaseHelper.Instance.Update(query);
        }
        public static Student GetStudentByUserID(int userID)
        {
            string query = $"SELECT * FROM Students WHERE UserID = {userID};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToStudent(dt.Rows[0]);
        }
        public static Student GetStudentByID(int studentID)
        {
            string query = $"SELECT * FROM Students WHERE StudentID = {studentID};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
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
            string query = $"SELECT * FROM Students ORDER BY TotalScore DESC LIMIT {limit};";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Student> list = new List<Student>();

            foreach (DataRow row in dt.Rows)
                list.Add(MapDataRowToStudent(row));

            return list;
        }

        // Helping Function
        private static Student MapDataRowToStudent(DataRow row)
        {
            return new Student
            {
                StudentID = Convert.ToInt32(row["StudentID"]),
                UserID = Convert.ToInt32(row["UserID"]),
                RegistrationNumber = row["RegistrationNumber"].ToString(),
                SkillLevelID = Convert.ToInt32(row["SkillLevelID"]),
                TotalScore = Convert.ToInt32(row["TotalScore"]),
                ProblemsSolved = Convert.ToInt32(row["ProblemsSolved"])
            };
        }

        // Validation Function
        public static bool IsStudentExist(string regno)
        {
            string query = $"SELECT COUNT(*) FROM Students WHERE RegistrationNumber = '{regno}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }

        // --- For AdminDashboard ---
        public static int TotalStudents()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Student';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int ActiveStudents()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Student' AND IsActive = 1;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static int InactiveStudents()
        {
            string query = "SELECT COUNT(*) FROM vw_users WHERE RoleName = 'Student' AND IsActive = 0;";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static DataTable GetStudentsForAdmin()
        {
            string query = "SELECT * FROM vw_studentsforadmin ORDER BY StudentID;";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
} 