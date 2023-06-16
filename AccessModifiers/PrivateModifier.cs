using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class MyClass1
    {
        private int privateVariable = 20;

        public void PrivateMethod()
        {
            Console.WriteLine("Private method called.");
        }
    }
}
