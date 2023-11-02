namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;
        private int classNumber;
        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, int classNumber)
        {
            this.name = name;
            this.age = age;
            this.classNumber = classNumber;
        }

        public int ClassNumber { get; set; }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old";
        }

        public void Print()
        {
            Console.WriteLine("console");
        }
    }
}
