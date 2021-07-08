using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityApp.Models;

namespace UniversityApp.Managers
{
    public class TeacherManager
    {
        public List<TeacherModel> GetTeachers(int count)
        {
            List<TeacherModel> teachers = new List<TeacherModel>(count);
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                teachers[i] = new TeacherModel(rnd.Next(25, 80), $"tch-{i + 1}", DateTime.Now.Date, Guid.NewGuid());
            }
            return teachers;
        }
    }
}
