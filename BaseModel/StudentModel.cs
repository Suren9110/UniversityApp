using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class StudentModel : BaseModel
    {
        public string _name;
        public int _age;
        public DateTime _birthDate;
        public TeacherModel _teacher;
        public StudentModel(int age, string name,  DateTime birthday, Guid id)
        {
            _name = name;
            _age = age;
            _birthDate = birthday;
            _id = id;
        }
    }
}
