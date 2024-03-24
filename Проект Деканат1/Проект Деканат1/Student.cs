using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_Деканат1
{
    public class Student
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        string birth;
        public string Birth { get { return birth; } set { birth = value; } }

        bool salary;
        public bool Salary { get { return salary; } set { salary = value; } }

        public Student(string Name, string Birth, bool Salary) { name = Name; birth = Birth; salary = Salary; }

        
    }


}
