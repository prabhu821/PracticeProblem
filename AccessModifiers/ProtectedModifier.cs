using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class MyBaseClass
    {
        protected int protectedVariable = 30;

        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected method called.");
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMember()
        {
            Console.WriteLine(protectedVariable);  // Accessible in derived class
            ProtectedMethod();                      // Accessible in derived class
        }
    }
}
