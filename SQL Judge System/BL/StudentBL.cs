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
        // --- STUDENT PANEL IN ADMIN DASHBOARD ---
        public static DataTable GetStudentsForAdmin()
        {
            return StudentDL.GetStudentsForAdmin();
        }
        public static int TotalStudents()
        {
            return StudentDL.TotalStudents();
        }
        public static int ActiveStudents()
        {
            return StudentDL.ActiveStudents();
        }
        public static int InactiveStudents()
        {
            return StudentDL.InactiveStudents();
        }

        public static void RegisterStudent(Student s)
        {
            if(s== null)
            {
                throw new ArgumentNullException(nameof(s), "Student object cannot be null.");
            }
            if(StudentDL.IsStudentExist(s.RegistrationNumber))
            {
                throw new InvalidOperationException($"A student with registration number {s.RegistrationNumber} already exists.");
            }
            s.StudentID = StudentDL.AddStudent(s);
        }
        public static Student GetStudentByUserID(int userId)
        {
            if(userId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(userId), "User ID cannot be negative.");
            }
            return StudentDL.GetStudentByUserID(userId);
        }
    }
}
