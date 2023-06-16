using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IShape
    {
        double CalculateArea();  // Method declaration
        void Display();          // Method declaration
    }

    // Implement the interface in a class
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public void Display()
        {
            Console.WriteLine($"Circle with radius {radius} and area {CalculateArea()}");
        }
    }

    // Implement the interface in another class
    public class Rectangle : IShape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalculateArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle with length {length}, width {width}, and area {CalculateArea()}");
        }
    }
}
