namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problem - Access Modifiers");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect option \n1.Public \n2.Private \n3.Protected \n4.Internal \n5.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        MyClass myObject = new MyClass();
                        Console.WriteLine(myObject.PublicVariable);  // Accessible
                        myObject.PublicMethod();
                        break;
                    case 2:
                        MyClass1 myObject1 = new MyClass1();
                        myObject1.PrivateMethod();
                        break ;
                    case 3:
                        MyDerivedClass derivedObject = new MyDerivedClass();
                        derivedObject.AccessProtectedMember();
                        break;
                    case 4:
                        MyInternalClass internalObject = new MyInternalClass();
                        Console.WriteLine(internalObject.InternalVariable);  // Accessible within the same assembly
                        internalObject.InternalMethod();                      // Accessible within the same assembly
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}