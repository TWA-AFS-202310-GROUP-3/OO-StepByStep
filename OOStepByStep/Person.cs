namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Introduce()
        {
            return string.Empty;
        }

        public void Print()
        {
            Console.WriteLine("console");
        }
    }
}
