using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassInfo
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public int ClassNumber { get; set; }

        public string AddStudent(Student student)
        {
            Students.Add(student);
            student.ClassNumber = ClassNumber;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Teacher.Introduce()} Welcome {student.Name} join class {ClassNumber}.");
            foreach (var stud in Students)
            {
                if (stud.Name != student.Name)
                {
                    stringBuilder.AppendLine($"{stud.Introduce()} Welcome {student.Name} join class {ClassNumber}.");
                }
            }

            return stringBuilder.ToString();
        }
    }
}
