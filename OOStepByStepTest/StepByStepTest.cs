using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;
using OOStepByStep;
namespace OOStepByStepTest
{
    public class StepByStepTest
    {
        [Fact]
        public void Should_return_introduction_when_given_person_info()
        {
            var person = new Person("Pengyu", 25);
            string msg = person.SelfIntroduce();

            Assert.Equal("My name is Pengyu. I am 25 years old", msg);
        }

        [Fact]
        public void Should_return_introduction_when_given_student_info()
        {
            var student = new Student("Wangke", 26);
            string msg = student.SelfIntroduce();

            Assert.Equal("My name is Wangke. I am 26 years old. I am a student", msg);
        }

        [Fact]
        public void Should_return_introduction_when_given_teacher_info()
        {
            var teacher = new Teacher("Xueheng", 30);
            string msg = teacher.SelfIntroduce();

            Assert.Equal("My name is Xueheng. I am 30 years old. I am a teacher", msg);
        }
    }
}
