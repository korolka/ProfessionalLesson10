using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfessionalEx4
{
    abstract class Person
    {
        protected abstract void Worked();

        protected abstract string Name
        {
            get;
        }
        protected abstract int Age { get; }

        public (string, int) TempleMethod()
        {
            Worked();
            return (Name, Age);
        }

    }

    class Junior : Person
    {

        private int age;
        private string name;
        public Junior(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        protected override int Age { get { return age; } }
        protected override string Name { get { return name; } }

        protected override void Worked()
        {
            Console.WriteLine("Junior is work");
        }
    }


    class Middle : Person
    {

        private int age;
        private string name;
        public Middle(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        protected override int Age { get { return age; } }
        protected override string Name { get { return name; } }

        protected override void Worked()
        {
            Console.WriteLine("Middle is work higher than junior");
        }
    }

    class Senior : Person
    {

        private int age;
        private string name;
        public Senior(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        protected override int Age { get { return age; } }
        protected override string Name { get { return name; } }

        protected override void Worked()
        {
            Console.WriteLine($"Senior has a lot of work");
        }
    }
}
