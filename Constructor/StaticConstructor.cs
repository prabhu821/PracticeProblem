using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Constructor
{
    public class MyClass
    {
        public static int Counter { get; set; }
        public string Name { get; set; }

        static MyClass()
        {
            Counter = 0;
            Console.WriteLine("Static constructor called.");
        }

        public MyClass(string name)
        {
            Name = name;
            Counter++;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Counter: {Counter}");
        }
    }
}
