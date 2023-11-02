using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        // private Person person;
        // private Teacher teacher;
        private List<Student> students = new ();
        private int classNumber;

        public Class(int classNumber)
        {
            this.classNumber = classNumber;
        }

        public string ClassMember(Person person)
        {
            if (person is Teacher)
            {
                // teacher = (Teacher)person;
                var memberIntroduction = person.Introduce();
                return memberIntroduction.Substring(0, memberIntroduction.Length - 1) + " of class " + classNumber + ".";
            }
            else if (person is Student)
            {
                students.Add((Student)person);
                foreach (var student in students)
                {
                    var memberIntroduction = student.Introduce();
                    return memberIntroduction.Substring(0, memberIntroduction.Length - 1) + " of class " + classNumber + ".";
                }
            }

            return "invalid input";
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
