using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private Person person;

        public Class(Person person)
        {
            this.person = person;
        }

        public string SelfIntroduceWithClassId(Person person, int classId)
        {
            var selfIntroductionWithoutClassId = person.SelfIntroduce();
            return selfIntroductionWithoutClassId.Substring(0, selfIntroductionWithoutClassId.Length - 1) + $" of class {classId}.";
        }
    }
}
