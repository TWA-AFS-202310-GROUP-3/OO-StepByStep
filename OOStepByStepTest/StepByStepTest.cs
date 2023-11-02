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
    }
}
