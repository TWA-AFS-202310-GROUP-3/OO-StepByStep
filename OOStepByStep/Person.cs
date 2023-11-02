namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;
        private int classNumber = int.MinValue;
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

        public int ClassNumber { get => classNumber; set => classNumber = value; }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old";
        }

        public string GetClassIntro()
        {
            if (this.ClassNumber == int.MinValue)
            {
                return string.Empty;
            }

            return $" of class {classNumber}";
        }

        public void Print()
        {
            Console.WriteLine("console");
        }
    }
}
