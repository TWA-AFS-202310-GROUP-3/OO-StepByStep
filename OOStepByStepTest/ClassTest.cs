using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class ClassTest
    {
        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age_class_of_teacher()
        {
            Teacher teacher = new Teacher("Amy", 30);
            var classobj = new Class(teacher);

            string msg = classobj.ClassMember(teacher, 2);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", msg);
        }

        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age_class_of_student()
        {
            Student student = new Student("Amy", 30);
            var classobj = new Class(student);

            string msg = classobj.ClassMember(student, 3);

            Assert.Equal("My name is Amy. I am 30 years old. I am a student of class 3.", msg);
        }
    }
}
