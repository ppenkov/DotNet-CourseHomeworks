using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesandObjects
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
    {
        this.name = "Ivaylo";
        this.age = 31;
        this.email = "kronik@abv.bg";
    }

        public void PrintInfo()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(email);
    }
    }
}
