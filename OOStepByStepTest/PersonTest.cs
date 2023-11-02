using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age()
        {
            var person = new Person("Tom", 21);

            string msg = person.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old.", msg);
        }

        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age_student()
        {
            Student student = new Student("Tom", 21);

            string msg = student.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old. I am a student.", msg);
        }

        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age_teacher()
        {
            Teacher teacher = new Teacher("Amy", 30);

            string msg = teacher.Introduce();

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher.", msg);
        }
    }
}
