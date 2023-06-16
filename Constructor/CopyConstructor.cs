using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Copy constructor
        public Person1(Person1 other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        // Parameterized constructor
        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
