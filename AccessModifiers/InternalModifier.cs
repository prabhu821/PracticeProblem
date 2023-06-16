using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class MyInternalClass
    {
        internal int InternalVariable = 40;

        internal void InternalMethod()
        {
            Console.WriteLine("Internal method called.");
        }
    }
}
