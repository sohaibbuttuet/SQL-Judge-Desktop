using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MidDb26_2025CS259;
using SQL_Judge_System.Models;

namespace SQL_Judge_System.DL
{
    internal class StudentDL
    {
        public static int AddStudent(Student student)
        {
            string query = $"INSERT INTO Students (StudentID, UserID, FullName, RegistrationNumber, SkillLevelID, TotalScore, ProblemsSolved) " +
                           $"VALUES ('{student.StudentID}', '{student.UserID}', '{student.FullName}', '{student.RegistrationNumber}', '{student.SkillLevelID}', {student.TotalScore}, {student.ProblemsSolved}); " +
                           $"SELECT LAST_INSERT_ID();";

            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query));
        }
        public static void UpdateStudent(Student student)
        {
            string query = $"UPDATE Students SET FullName = '{student.FullName}', RegistrationNumber = '{student.RegistrationNumber}', " +
                           $"SkillLevelID = '{student.SkillLevelID}', TotalScore = {student.TotalScore}, ProblemsSolved = {student.ProblemsSolved} " +
                           $"WHERE StudentID = '{student.StudentID}';";
            DatabaseHelper.Instance.Update(query);
        }
        public static void DeleteStudent(int studentID)
        {
            string query = $"DELETE FROM Students WHERE StudentID = '{studentID}';";
            DatabaseHelper.Instance.Update(query);
        }
        public static Student GetStudentByUserID(int userID)
        {
            string query = $"SELECT * FROM Students WHERE UserID = '{userID}';";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 0)
                return null;

            return MapDataRowToStudent(dt.Rows[0]);
        }
        public static Student GetStudentByID(int studentID)
        {
            string query = $"SELECT * FROM Students WHERE StudentID = '{studentID}';";
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
        public static List<Student> GetStudentsBySkillLevel(int skillLevelID)
        {
            string query = $"SELECT * FROM Students WHERE SkillLevelID = '{skillLevelID}';";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            List<Student> students = new List<Student>();
            foreach (DataRow row in dt.Rows)
            {
                students.Add(MapDataRowToStudent(row));
            }
            return students;
        }

        // Helping Function
        private static Student MapDataRowToStudent(DataRow row)
        {
            return new Student
            {
                StudentID = Convert.ToInt32(row["StudentID"]),
                UserID = Convert.ToInt32(row["UserID"]),
                FullName = row["FullName"].ToString(),
                RegistrationNumber = row["RegistrationNumber"].ToString(),
                SkillLevelID = Convert.ToInt32(row["SkillLevelID"]),
                TotalScore = Convert.ToInt32(row["TotalScore"]),
                ProblemsSolved = Convert.ToInt32(row["ProblemsSolved"])
            };
        }

        // Validation Function
        public static bool IsRegistrationNumberUnique(string registrationNumber)
        {
            string query = $"SELECT COUNT(*) FROM Students WHERE RegistrationNumber = '{registrationNumber}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) == 0;
        }
        public static bool IsStudentExist(int studentID)
        {
            string query = $"SELECT COUNT(*) FROM Students WHERE StudentID = '{studentID}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static bool IsStudentExistByUserID(int userID)
        {
            string query = $"SELECT COUNT(*) FROM Students WHERE UserID = '{userID}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
        public static bool IsStudentExistByRegistrationNumber(string registrationNumber)
        {
            string query = $"SELECT COUNT(*) FROM Students WHERE RegistrationNumber = '{registrationNumber}';";
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query)) > 0;
        }
    }
} 