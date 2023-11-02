using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class StudentTeacherTest
    {
        [Fact]
        public void Should_return_true_When_Teacher_calss_exist()
        {
            var teacher = new Teacher("Tom", 20);
            Assert.NotNull(teacher);
        }

        [Theory]
        [InlineData("Tom", 21)]
        public void Should_return_selfIntroduction_When_teacher_selfIntroduce_Given_name_age(string name, int age)
        {
            var expect = "My name is Tom. I am 21 years old. I am a teacher.";

            var teacher = new Teacher(name, age);
            var actual = teacher.SelfIntroduction();

            Assert.Equal(expect, actual);
        }
    }
}
