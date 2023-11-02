namespace OOStepByStepTest
{
    using OOStepByStep;
    using System;
    using Xunit;

    public class UnitTest1
    {
        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_when_introduce_given_person(string name, int age)
        {
            Person person = new Person(name, age);
            var result = person.Introduce();

            Assert.Equal("My name is haha. I am 11 years old", result);
        }

        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_job_when_introduce_given_student(string name, int age)
        {
            Person student = new Student(name, age);
            var result = student.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a student", result);
        }

        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_job_when_introduce_given_teacher(string name, int age)
        {
            Person teacher = new Teacher(name, age);
            var result = teacher.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a teacher", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_print_name_age_job_class_when_introduce_given_student_belongs_to_class(string name, int age, int classNumber)
        {
            Person person = new Student(name, age, 2);
            person.ClassNumber = classNumber;
            var result = person.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a student of class 2", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_print_name_age_job_class_when_introduce_given_teacher_belongs_to_class(string name, int age, int classNumber)
        {
            Person person = new Teacher(name, age, 2);
            person.ClassNumber = classNumber;
            var result = person.Introduce();
            Assert.Equal("My name is haha. I am 11 years old. I am a teacher of class 2", result);
        }
    }
}
