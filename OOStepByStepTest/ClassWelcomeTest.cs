using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class ClassWelcomeTest
    {
        [Fact]
        public void Should_return_silence_when_add_teacher()
        {
            // Given
            int classNumber = 3;
            Class exampleClass = new Class(classNumber);
            Teacher teacher = new Teacher("Amy", 30, classNumber);
            string expectedResult = "Silence.";
            // When
            string result = exampleClass.AddTeacher(teacher);
            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_return_welcome_from_teacher_when_add_first_student()
        {
            // Given
            int classNumber = 3;
            Class exampleClass = new Class(classNumber);
            Teacher teacher = new Teacher("Amy", 30, classNumber);
            string t = exampleClass.AddTeacher(teacher);
            Student student = new Student("Tom", 18, classNumber);
            string expectedResult = "My name is Amy. I am 30 years old. I am a teacher. I am a teacher of class 3. Welcome Tom join class 3. ";
            // When
            string result = exampleClass.AddStudent(student);
            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_return_welcome_from_everyone_when_add_other_student()
        {
            // Given
            int classNumber = 3;
            Class exampleClass = new Class(classNumber);
            Teacher teacher = new Teacher("Amy", 30, classNumber);
            Student student1 = new Student("Tom", 18, classNumber);
            Student student2 = new Student("Jim", 17, classNumber);
            string t = exampleClass.AddTeacher(teacher);
            string s = exampleClass.AddStudent(student1);
            string expectedResult = "My name is Amy. I am 30 years old. I am a teacher. I am a teacher of class 3. Welcome Jim join class 3. \r\nMy name is Tom. I am 18 years old. I am a student. I am a student of class 3. Welcome Jim join class 3. ";
            // When
            string result = exampleClass.AddStudent(student2);
            // Then
            Assert.Equal(expectedResult, result);
        }
    }
}
