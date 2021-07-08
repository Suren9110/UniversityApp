using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.Managers
{
    public class UniversityManager
    {
        public List<TeacherModel> AddStudentsToTeachers(List<TeacherModel> teachers, List<StudentModel> students)
        {
            int studentsCount = students.Count / teachers.Count;
            int lastTeacher = students.Count % teachers.Count + studentsCount;
            int TeachersOfFirst = teachers.Count - 1;
            for (int i = 0; i < TeachersOfFirst; i++)
            {
                teachers[i]._students = new List<StudentModel>(studentsCount);
                for (int j = 0; j < studentsCount; j++)
                {
                    var student = students[studentsCount * i + 1];
                    teachers[i]._students.Add(student);
                }
            }
            return teachers;
        }
        public List<StudentModel> AddTeachersToStudents(List<TeacherModel> teachers, List<StudentModel> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Guid curStudentId = students[i]._id;
                for (int j = 0; j < teachers.Count; j++)
                {
                    var res = teachers[j]._students.FirstOrDefault(x => x._id == curStudentId);
                    if (res != null)
                        students[i]._teacher = teachers[j];
                }
            }
            return students;
        }
    }
}
