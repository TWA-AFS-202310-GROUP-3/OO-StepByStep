using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class ClassroomTest
    {
        [Fact]
        public void Should_return_selfIntroduction_When_classRoom_selfIntroduction_Given_person()
        {
            var expect = "My name is Tom. I am 25 years old. I am a student of class 2.";

            Person student = new Student("Tom", 25);
            ClassRoom classRoom = new ClassRoom(2);
            classRoom.JoinIn(student);
            var actual = classRoom.IntroduceSelf(student);

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_return_welcome_selfIntroductions_When_classRoom_JoinIn_Given_person()
        {
            List<string> expect = new List<string>{ "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.",
                                        "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2." };
            Person jim = new Student("Jim", 25);
            Person amy = new Teacher("Amy", 30);
            Person tom = new Student("Tom", 18);
            ClassRoom classRoom = new ClassRoom(2);
            classRoom.JoinIn(amy);
            classRoom.JoinIn(tom);
            var actual = classRoom.JoinIn(jim);
            Assert.Equal(expect, actual);
        }
    }
}
