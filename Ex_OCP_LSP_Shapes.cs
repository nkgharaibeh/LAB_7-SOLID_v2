using System;
using System.Collections.Generic;

namespace Ex_OCP_LSP_Shapes
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public double CalculateArea() => Math.PI * Radius * Radius;
    }

    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double width, double height)
        {
            Width = width; Height = height;
        }
        public double CalculateArea() => Width * Height;
    }

    class Program
    {
        static void Main()
        {
            // ✅ OCP:
            // Add new shapes (Triangle, Square...) without modifying this loop.
            List<IShape> shapes = new()
            {
                new Circle(2),
                new Rectangle(3, 4)
            };

            foreach (IShape s in shapes)
            {
                // ✅ LSP (Liskov Substitution Principle):
                // Any IShape implementation must behave correctly when used as IShape.
                Console.WriteLine("Area = " + s.CalculateArea());
            }

            Console.ReadKey();
        }
    }
}

/*
SOLID Links:
- OCP: Extend by adding new classes, not editing existing client code.
- LSP: Any IShape must be safely substitutable for IShape without breaking expectations.
*/
