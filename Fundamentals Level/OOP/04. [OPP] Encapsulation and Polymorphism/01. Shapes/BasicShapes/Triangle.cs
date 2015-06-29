using System;
using Shapes.BasicShapes;

namespace Shapes.BasicShapes
{
    public class Triangle : BasicShape
    {
        private double sideA;
        private double sideB;

        public Triangle(double sideA, double sideB, double sideC, double heightC)
            : base(sideC, heightC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public double SideA
        {
            get { return this.sideA; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of a triangle should be positive.");
                }
                this.sideA = value;
            }
        }

        public double SideB
        {
            get { return this.sideB; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The side of a triangle should be positive.");
                }
                this.sideB = value;
            }
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return this.SideA + this.SideB + this.Width;
        }
    }
}
