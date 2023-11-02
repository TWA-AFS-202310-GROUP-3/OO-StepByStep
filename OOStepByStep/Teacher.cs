using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNumber = 0;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            if (classNumber > 0)
            {
                return base.Introduce() + $" I am a teacher of class {classNumber}.";
            }
            else
            {
                return base.Introduce() + " I am a teacher.";
            }
        }
    }
}
