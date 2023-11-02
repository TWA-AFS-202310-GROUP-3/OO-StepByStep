using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public partial class ClassRoom
    {
        private int number;
        private Teacher teacher;
        private List<Student> students;

        public ClassRoom(int number)
        {
            this.number = number;
        }

        public string IntroduceSelf(Person person)
        {
            var selfIntroductionWithoutClassNumber = person.SelfIntroduction();
            return selfIntroductionWithoutClassNumber.Substring(0, selfIntroductionWithoutClassNumber.Length - 1) + $" of class {this.number}";
        }
    }
}
