namespace Constructor;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Practice Problem - Constructor!");
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("\nSelect option \n1.Default Constructor \n2.Parameterised Constructor \n3.Copy Constructor " +
                "\n4.Static Constructor \n5.Exit");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    Person person = new Person();
                    Console.WriteLine(person.Name);  
                    Console.WriteLine(person.Age);
                    break;
                case 2:
                    Car myCar = new Car("Toyota", "Corolla");
                    Console.WriteLine(myCar.Make);   
                    Console.WriteLine(myCar.Model); 
                    break;
                case 3:
                    Person1 person1 = new Person1("John", 30);
                    Person1 person2 = new Person1(person1); // Using the copy constructor
                    person1.Display(); 
                    person2.Display(); 
                    // Modifying person2
                    person2.Name = "Jane";
                    person2.Age = 25;
                    person1.Display(); 
                    person2.Display(); 
                    break;
                case 4:
                    MyClass obj1 = new MyClass("Object 1");
                    obj1.Display(); // Output: Name: Object 1, Counter: 1

                    MyClass obj2 = new MyClass("Object 2");
                    obj2.Display(); // Output: Name: Object 2, Counter: 2

                    MyClass obj3 = new MyClass("Object 3");
                    obj3.Display(); // Output: Name: Object 3, Counter: 3
                    break;
                default:
                    flag = false;
                    break;
            }
        }
    }
}