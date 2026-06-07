using SQL_Judge_System.DL;
using SQL_Judge_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Judge_System.BL
{
    internal class StudentBL
    {
        // ==========================================
        // STUDENT REGISTRATION (NEW USERS)
        // ==========================================
        public static void RegisterStudent(Student s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s), "Student object cannot be null.");

            if (StudentDL.IsStudentExist(s.RegistrationNumber))
                throw new InvalidOperationException($"A student with registration number {s.RegistrationNumber} already exists.");

            s.StudentID = StudentDL.AddStudent(s);
        }

        // ==========================================
        // STUDENT PROFILE UPDATES (EXISTING USERS)
        // ==========================================
        public static void UpdateStudent(Student s)
        {
            if (s == null)
                throw new ArgumentNullException(nameof(s), "Student object cannot be null.");

            if (StudentDL.IsStudentExist(s.StudentID, s.RegistrationNumber))
                throw new InvalidOperationException($"A student with registration number {s.RegistrationNumber} already exists.");

            StudentDL.UpdateStudent(s);
        }
        public static Student GetStudentByUserID(int userId)
        {
            if (userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID cannot be negative.");
            }
            return StudentDL.GetStudentByUserID(userId);
        }

        // ==========================================
        // ADMIN/Student DASHBOARD ANALYTICS PANEL
        // ==========================================
        public static DataTable GetStudents()
        {
            return StudentDL.GetStudents();
        }
        public static int GetRank(int studentId)
        {
            if (studentId <= 0)
                throw new Exception("Invalid Student ID");

            return StudentDL.GetRank(studentId);
        }
    }
}
