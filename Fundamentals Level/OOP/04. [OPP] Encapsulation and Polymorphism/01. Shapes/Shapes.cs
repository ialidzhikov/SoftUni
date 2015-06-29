using System;
using Shapes.BasicShapes;
using Shapes.Interfaces;

namespace Shapes
{
    public class Shapes
    {
        static void Main()
        {
            IShape[] shapes = new IShape[]
            {
                new Circle(3),
                new Rectangle(4, 5),
                new Triangle(3, 4, 5, 2.4),
                new Triangle(3, 6, 8, 5.9),
                new Rectangle(10, 10),
                new Rectangle(2, 1),
                new Circle(10), 
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine("Type: {0,-10} Area: {1:F2} Perimeter: {2:F2}",
                    shape.GetType().Name, shape.CalculateArea(), shape.CalculatePerimeter());
            }
        }
    }
}
