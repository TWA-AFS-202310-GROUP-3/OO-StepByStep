using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_return_true_When_Person_calss_exist()
        {
            var person = new Person();
            Assert.NotNull(person);
        }

        [Theory]
        [InlineData("Tom", 21)]
        public void Should_return_selfIntroduction_When_person_introduce_Given_name_age(string name, int age)
        {
            var expect = "My name is Tom. I am 21 years old";

            var person = new Person(name, age);
            var actual = person.SelfIntroduction();

            Assert.Equal(expect, actual);
        }
    }
}
