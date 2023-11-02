using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNumber = 0;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            if (classNumber > 0)
            {
                return base.Introduce() + $" I am a student of class {classNumber}.";
            }
            else
            {
                return base.Introduce() + " I am a student.";
            }
        }
    }
}
