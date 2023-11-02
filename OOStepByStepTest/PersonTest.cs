using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_return_msg_when_Introduce_given_name_age()
        {
            var person = new Person();

            string msg = person.Introduce();

            Assert.Equal("My name is Tom. I am 21 years old.", msg);
        }
    }
}
