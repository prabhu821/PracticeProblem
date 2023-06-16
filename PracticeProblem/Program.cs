using Interface;

namespace PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problem - Interface Concept");
            Circle circle = new Circle(5);
            circle.Display();  

            Rectangle rectangle = new Rectangle(4, 6);
            rectangle.Display();  
        }
    }
}