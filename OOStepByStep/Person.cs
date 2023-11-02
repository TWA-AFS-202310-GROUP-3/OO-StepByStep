using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
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

        public virtual string SelfIntroduction()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }
}
