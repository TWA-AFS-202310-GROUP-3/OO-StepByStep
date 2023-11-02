namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Theory]
        [InlineData("haha", 11)]
        public void Should_print_name_age_when_introduce_given_person(string name, int age)
        {
            Person person = new Person(name, age);
            var result = person.Introduce();

            Assert.Equal("My name is haha, I am 11 years old", result);
        }
    }
}
