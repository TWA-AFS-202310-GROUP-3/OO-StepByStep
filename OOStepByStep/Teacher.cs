using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            return base.SelfIntroduce() + " I am a teacher.";
        }
    }
}
