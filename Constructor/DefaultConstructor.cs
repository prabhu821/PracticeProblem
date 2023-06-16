using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Default constructor
        public Person()
        {
            Name = "John Doe";
            Age = 30;
        }
    }
}
