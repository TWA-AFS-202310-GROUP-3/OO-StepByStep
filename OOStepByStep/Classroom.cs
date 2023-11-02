using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Classroom
    {
        private int classNumber;
        private Teacher teacher;
        private List<Student> students = new List<Student>();

        public Classroom()
        {
        }

        public Classroom(int classNumber, Teacher teacher)
        {
            this.classNumber = classNumber;
            this.teacher = teacher;
        }

        public Teacher Teacher => teacher;
        public List<Student> Students => students;
        public int ClassNumber => classNumber;

        public string AddStudent(Student student)
        {
            string greeting = Greeting(student.Name);
            this.students.Add(student);
            student.ClassNumber = this.classNumber;
            return greeting;
        }

        public string GenerateGreetingTo(string name)
        {
            return $"Welcome {name} join class {classNumber}";
        }

        public string Greeting(string name)
        {
            List<string> greeting = new List<string>();
            greeting.Add($"{teacher.Introduce()} {GenerateGreetingTo(name)}.");
            students.ForEach(student =>
            {
                greeting.Add($"{student.Introduce()} {GenerateGreetingTo(name)}.");
            });
            return string.Join('\n', greeting);
        }
    }
}
