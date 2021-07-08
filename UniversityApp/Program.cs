using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;
using UniversityApp.Managers;

namespace UniversityApp
{
    class Program
    {
        static void Main(string[] args)
        {            StudentManager studentManager = new StudentManager();
            List<StudentModel> students = studentManager.GetStudents(63);
            TeacherManager teacherManager = new TeacherManager();
            List<TeacherModel> teachers = teacherManager.GetTeachers(4);
            UniversityManager universityManager = new UniversityManager();
            List<TeacherModel> swappedTeachers = universityManager
                                             .AddStudentsToTeachers(teachers, students);
            List<StudentModel> swappedStudens = universityManager
                                   .AddTeachersToStudents(swappedTeachers, students);
        }
    }
}
