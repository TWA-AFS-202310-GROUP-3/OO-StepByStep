using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class StepByStepTest
    {
        [Fact]
        public void Should_return_name_and_age()
        {
            //Given
            Person person = new Person { Name = "Tom", Age = 21 };

            //When
            string introduction = person.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_return_name_and_age_with_a_student()
        {
            //Given
            Student student = new Student { Name = "Tom", Age = 18 };

            //When
            string introduction = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_return_name_and_age_with_a_teacher()
        {
            //Given
            Teacher teacher = new Teacher { Name = "Amy", Age = 30 };

            //When
            string introduction = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduction);
        }

        [Fact]
        public void Should_return_name_age_with_a_student_and_class_number()
        {
            //Given
            var student = new Student { Name = "Tom", Age = 18, ClassNumber = 2 };

            //When
            var result = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student of class 2.", result);
        }

        [Fact]
        public void Should_return_name_age_with_a_teacher_and_class_number()
        {
            //Given
            var teacher = new Teacher { Name = "Amy", Age = 30, ClassNumber = 2 };

            //When
            var result = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", result);
        }

        [Fact]
        public void Should_return_name_age_when_come_new_student()
        {
            //Given
            var teacher = new Teacher { Name = "Amy", Age = 30, ClassNumber = 2 };
            var class2 = new ClassInfo { ClassNumber = teacher.ClassNumber, Teacher = teacher };

            var studentTom = new Student { Name = "Tom", Age = 18 };
            var studentXianke = new Student { Name = "Xianke", Age = 20 };
            var studentJim = new Student { Name = "Jim", Age = 18 };

            class2.AddStudent(studentTom);
            class2.AddStudent(studentXianke);

            var expectedOutput =
                "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\r\n" +
                "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\r\n" +
                "My name is Xianke. I am 20 years old. I am a student of class 2. Welcome Jim join class 2.\r\n";

            //When
            var result = class2.AddStudent(studentJim);

            //Then
            Assert.Equal(expectedOutput, result);
        }
    }
}
