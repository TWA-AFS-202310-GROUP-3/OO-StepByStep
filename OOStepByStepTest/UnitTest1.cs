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

            Assert.Equal("My name is haha. I am 11 years old.", result);
        }

        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_job_when_introduce_given_student(string name, int age)
        {
            Person student = new Student(name, age);
            var result = student.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a student.", result);
        }

        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_job_when_introduce_given_teacher(string name, int age)
        {
            Person teacher = new Teacher(name, age);
            var result = teacher.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a teacher.", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_print_name_age_job_class_when_introduce_given_student_belongs_to_class(string name, int age, int classNumber)
        {
            Person person = new Student(name, age);
            person.ClassNumber = classNumber;
            var result = person.Introduce();

            Assert.Equal("My name is haha. I am 11 years old. I am a student of class 2.", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_print_name_age_job_class_when_introduce_given_teacher_belongs_to_class(string name, int age, int classNumber)
        {
            Person person = new Teacher(name, age);
            person.ClassNumber = classNumber;
            var result = person.Introduce();
            Assert.Equal("My name is haha. I am 11 years old. I am a teacher of class 2.", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_teacher_of_class_introduce_when_new_student_join_class(string name, int age, int classNumber)
        {
            //Given
            Student newJoinPerson = new Student(name, age);
            Teacher teacher = new Teacher("Dr.Wu", classNumber);
            Classroom classroom = new Classroom(classNumber, teacher);

            //When
            var result = classroom.AddStudent(newJoinPerson);

            //Then
            Assert.Equal("My name is Dr.Wu. I am 2 years old. I am a teacher. Welcome haha join class 2.", result);
        }

        [Theory]
        [InlineData("haha", 11, 2)]
        public void Should_people_of_class_introduce_when_new_student_join_class(string name, int age, int classNumber)
        {
            //Given
            Student newJoinPerson = new Student(name, age);
            Teacher teacher = new Teacher("Dr.Wu", classNumber);
            Student student1 = new Student("wuwu", 10);
            Student student2 = new Student("yiwuyiwu", 12);
            Classroom classroom = new Classroom(classNumber, teacher);
            classroom.AddStudent(student1);
            classroom.AddStudent(student2);

            //When
            var result = classroom.AddStudent(newJoinPerson);

            //Then
            Assert.Equal("My name is Dr.Wu. I am 2 years old. I am a teacher. Welcome haha join class 2.\nMy name is wuwu. I am 10 years old. I am a student of class 2. Welcome haha join class 2.\nMy name is yiwuyiwu. I am 12 years old. I am a student of class 2. Welcome haha join class 2.", result);
        }
    }
}
