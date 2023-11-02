using OOStepByStep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class StepByStepTest
    {
        [Fact]
        public void Should_return_name_and_age()
        {
            //Given
            Person person = new Person("Tom", 21);

            //When
            string introduction = person.Introduce();

            //Then
            Assert.Equal("My name is Tom. I am 21 years old.", introduction);
        }
    }
}
