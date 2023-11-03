using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private int classNumber = 2;
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        private string welcomeWords;

        public Class(int classNumber)
        {
            this.classNumber = classNumber;
        }

        public string AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            return "Silence.";
        }

        public string AddStudent(Student newStudent)
        {
            welcomeWords = $"Welcome {newStudent.Name} join class {classNumber}. ";
            List<string> welcomeWordsTogether = new List<string>();
            welcomeWordsTogether.Add(teacher.IntroduceSelf() + welcomeWords);
            foreach (Student student in students)
            {
                welcomeWordsTogether.Add(student.IntroduceSelf() + welcomeWords);
            }

            students.Add(newStudent);
            return string.Join("\r\n", welcomeWordsTogether.ToArray());
        }
    }
}
