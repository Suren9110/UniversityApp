using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityApp.Models
{
    public class TeacherModel : BaseModel
    {
        public string _name;
        public int _age;
        public DateTime _birthDate;
        public List<StudentModel> _students;
        public TeacherModel(int age, string name,  DateTime birthday, Guid id)
        {
            _name = name;
            _age = age;
            _birthDate = birthday;
            _id = id;
        }
    }
}
