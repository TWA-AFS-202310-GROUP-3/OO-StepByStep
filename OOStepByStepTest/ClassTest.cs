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
            var classobj = new Class(2);

            string msg = classobj.ClassMember(teacher);

            Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2.", msg);
        }

        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age_class_of_student()
        {
            Student student1 = new Student("Tom", 21);
            Student student2 = new Student("Eleanor", 23);
            var classobj = new Class(3);
            classobj.AddStudent(student1);

            string msg = classobj.ClassMember(student2);

            Assert.Equal("My name is Tom. I am 21 years old. I am a student of class 3.", msg);
        }
    }
}
