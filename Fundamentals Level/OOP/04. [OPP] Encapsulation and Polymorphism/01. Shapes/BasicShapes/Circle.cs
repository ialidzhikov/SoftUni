using System;
using Shapes.Interfaces;

namespace Shapes.BasicShapes
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double CalculateArea()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public double CalculatePerimeter()
        {
            return this.Radius * Math.PI * 2;
        }
    }
}
