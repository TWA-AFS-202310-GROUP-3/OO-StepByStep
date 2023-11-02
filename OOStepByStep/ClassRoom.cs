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
            if (person is Teacher)
            {
                if (this.teacher == null || !IsThePerson(this.teacher, person))
                {
                    return string.Empty;
                }
            }

            if (person is Student)
            {
                if (this.students == null)
                {
                    return string.Empty;
                }

                if (!IncludesStudent(person)) { return string.Empty; }
            }

            var selfIntroductionWithoutClassNumber = person.SelfIntroduction();
            return selfIntroductionWithoutClassNumber.Substring(0, selfIntroductionWithoutClassNumber.Length - 1) + $" of class {this.number}.";
        }

        public bool IsThePerson(Person p1, Person p2)
        {
            return p1.Name == p2.Name && p1.Age == p2.Age;
        }

        public bool IncludesStudent(Person student)
        {
            bool found = false;
            for (int i = 0; i < this.students.Count; i++)
            {
                var aStudent = this.students[i];
                if (IsThePerson(aStudent, student))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

    }
}
