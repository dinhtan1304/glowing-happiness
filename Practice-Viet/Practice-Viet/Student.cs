using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Viet
{
    public class Student
    {
        //Property
        public string Code { get; set; }
        private string _name;
        public string Name
        {
            get { return _name.ToUpper(); }
            set { _name = value; }
        }

        public int Age { get; set; }

        //method
        public Student()
        {

        }

        public Student(string code, string name, int age)
        {
            Code = code;
            Name = name;
            Age = age;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Age;
        }
    }
}
