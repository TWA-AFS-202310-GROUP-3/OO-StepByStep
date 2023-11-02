using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_return_name_and_age_when_introduce()
        {
            // Given
            Person person = new Person("Tom", 21);
            string expectedResult = "My name is Tom. I am 21 years old.";
            // When
            string result = person.IntroduceSelf();
            // Then
            Assert.Equal(expectedResult, result);
        }
    }
}
