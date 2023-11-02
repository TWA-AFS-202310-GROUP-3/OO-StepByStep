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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string IntroduceSelf()
        {
            return $"My name is {name}. I am {age} years old. ";
        }
    }

    public class Student : Person
    {
        private string classIntroduction = string.Empty;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            this.classIntroduction = $"I am a student of class {classNumber}. ";
        }

        public override string IntroduceSelf()
        {
            return base.IntroduceSelf() + "I am a student. " + classIntroduction;
        }
    }

    public class Teacher : Person
    {
        private string classIntroduction = string.Empty;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
        {
            this.classIntroduction = $"I am a teacher of class {classNumber}. ";
        }

        public override string IntroduceSelf()
        {
            return base.IntroduceSelf() + "I am a teacher. " + classIntroduction;
        }
    }
}
