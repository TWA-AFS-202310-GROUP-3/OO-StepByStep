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
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string IntroduceSelf()
        {
            return $"My name is {name}. I am {age} years old. ";
        }
    }

    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string IntroduceSelf()
        {
            return base.IntroduceSelf() + "I am a student. ";
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string IntroduceSelf()
        {
            return base.IntroduceSelf() + "I am a teacher. ";
        }
    }
}
