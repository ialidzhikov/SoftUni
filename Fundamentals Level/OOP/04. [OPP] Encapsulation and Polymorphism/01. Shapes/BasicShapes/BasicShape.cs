using System;
using System.Globalization;
using Shapes.Interfaces;

namespace Shapes.BasicShapes
{
    public abstract class BasicShape : IShape
    {
        #region Fields

        private double width;
        private double height;

        #endregion

        #region Constructors

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        #endregion

        #region Properties

        public double Width
        {
            get { return this.width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width cannot be negative.");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height cannot be negative.");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        #endregion

        #region Methods

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        #endregion
    }
}
