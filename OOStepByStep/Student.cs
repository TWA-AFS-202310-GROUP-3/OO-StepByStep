using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string classIntro = string.Empty;
        public Student()
        {
        }

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age, classNumber)
        {
            classIntro = $" of class {classNumber}";
        }

        public override string Introduce()
        {
            return $"{base.Introduce()}. I am a student{classIntro}";
        }
    }
}
