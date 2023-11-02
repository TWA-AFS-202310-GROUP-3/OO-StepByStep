using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ClassroomTest
    {
        [Fact]
        public void Should_return_selfIntroduction_When_classRoom_selfIntroduction_Given_person()
        {
            var expect = "My name is Tom. I am 25 years old. I am a student of class 2";

            Person student = new Student("Tom", 25);
            ClassRoom classRoom = new ClassRoom(2);
            var actual = classRoom.IntroduceSelf(student);

            Assert.Equal(expect, actual);
        }
    }
}
