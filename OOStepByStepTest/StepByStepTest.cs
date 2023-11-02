using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Person person = new Person("Tom", 21);

            //When
            string introduction = person.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }

        [Fact]
        public void Should_return_name_and_age_with_a_student()
        {
            //Given
            Student student = new Student("Tom", 18);

            //When
            string introduction = student.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 18 years old. I am a student.", introduction);
        }

        [Fact]
        public void Should_return_name_and_age_with_a_teacher()
        {
            //Given
            Teacher teacher = new Teacher("Amy", 30);

            //When
            string introduction = teacher.Introduce();

            //Then
            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", introduction);
        }
    }
}
