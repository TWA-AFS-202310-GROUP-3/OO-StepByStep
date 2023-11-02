using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public int ClassNumber { get; set; }

        public override string Introduce()
        {
            if (ClassNumber > 0)
            {
                return base.Introduce() + $" I am a student of class {ClassNumber}.";
            }
            else
            {
                return base.Introduce() + " I am a student.";
            }
        }
    }
}
