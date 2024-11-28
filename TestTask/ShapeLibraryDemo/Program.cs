using System;
using ShapeLibrary;

namespace ShapeLibraryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]
            {
                new Circle(5),
                new Triangle(3, 4, 5),
                new Circle(2.5),
                new Triangle(6, 6, 6)
            };

            foreach (var shape in shapes)
            {
                double area = shape.GetArea();
                Console.WriteLine($"Площадь фигуры ({shape.GetType().Name}): {area:F2}");

                if (shape is Triangle triangle)
                {
                    Console.WriteLine($"Является прямоугольным: {triangle.IsRightAngled()}");
                }

                Console.WriteLine();
            }
        }
    }
}

