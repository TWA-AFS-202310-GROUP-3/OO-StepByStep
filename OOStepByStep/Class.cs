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

        public string ClassMember(Person person, int classNumber)
        {
            return person.Introduce() + " of class " + classNumber;
        }
    }
}
