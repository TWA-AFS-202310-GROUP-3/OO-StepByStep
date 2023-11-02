using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_return_name_and_age_when_introduce()
        {
            // Given
            Person person = new Person("Tom", 21);
            string expectedResult = "My name is Tom. I am 21 years old. ";
            // When
            string result = person.IntroduceSelf();
            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_return_name_and_age_and_student_when_introduce()
        {
            // Given
            Student student = new Student("Tom", 18);
            string expectedResult = "My name is Tom. I am 18 years old. I am a student. ";
            // When
            string result = student.IntroduceSelf();
            // Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_return_name_and_age_and_teacher_when_introduce()
        {
            // Given
            Teacher teacher = new Teacher("Amy", 30);
            string expectedResult = "My name is Amy. I am 30 years old. I am a teacher. ";
            // When
            string result = teacher.IntroduceSelf();
            // Then
            Assert.Equal(expectedResult, result);
        }
    }
}
