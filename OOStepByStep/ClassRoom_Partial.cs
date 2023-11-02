using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public partial class ClassRoom
    {
        public List<string> JoinIn(Person person)
        {
            List<string> result = new List<string>();
            if (person is Teacher)
            {
                if (!(this.teacher is null))
                {
                    return null;
                }

                this.teacher = new Teacher(person.Name, person.Age);
                if (this.students != null)
                {
                    for (int i = 0; i < this.students.Count; i++)
                    {
                        result.Add(Welcome(this.students[i], person));
                    }
                }
            }
            else if (person is Student)
            {
                if (this.students == null)
                {
                    this.students = new List<Student>();
                }

                if (IncludesStudent(person))
                {
                    return null;
                }

                if (this.teacher != null)
                {
                    result.Add(Welcome(this.teacher, person));
                }

                if (this.students != null)
                {
                    for (int i = 0; i < this.students.Count; i++)
                    {
                        result.Add(Welcome(this.students[i], person));
                    }
                }

                this.students.Add(person as Student);
            }

            return result;
        }

        public string Welcome(Person welcomer, Person welcomee)
        {
            return $"{IntroduceSelf(welcomer)} Welcome {welcomee.Name} join class {this.number}.";
        }
    }
}
