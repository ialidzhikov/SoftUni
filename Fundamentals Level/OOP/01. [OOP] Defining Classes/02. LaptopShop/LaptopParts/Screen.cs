using System;

namespace LaptopParts
{
    public class Screen
    {
        #region Fields

        private double sizeInches;
        private Tuple<int, int> resolution;
        private string graphicsDisplayResolution;
        private string details;

        #endregion

        #region Constructors

        public Screen(double sizeInches, Tuple<int, int> resolution, string graphicsDisplayResolution, string details)
        {
            this.SizeInches = sizeInches;
            this.Resolution = resolution;
            this.GraphicsDisplayResolution = graphicsDisplayResolution;
            this.Details = details;
        }

        #endregion

        #region Properties

        public double SizeInches
        {
            get { return this.sizeInches; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The size of the screen should be positive.");
                }
                else
                {
                    this.sizeInches = value;
                }
            }
        }

        public double SizeCentimeters
        {
            get { return this.SizeInches * 2.54; }
        }

        public Tuple<int, int> Resolution
        {
            get { return this.resolution; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The resolution cannot be null.");
                }
                else if (value.Item1 < 0 || value.Item2 < 0)
                {
                    throw new ArgumentOutOfRangeException("The resolution parameters sould be positive.");
                }
                else
                {
                    this.resolution = value;
                }
            }
        }

        public string GraphicsDisplayResolution
        {
            get { return this.graphicsDisplayResolution; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The graphics display resolution cannot be null, empty or whitespace.");
                }
                else
                {
                    this.graphicsDisplayResolution = value;
                }
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("the sreen details cannot be null, empty or whitespace.");
                }
                else
                {
                    this.details = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("{0:F1}\" ({1:F2} cm) - {2} x {3} ({4}), {5}",
                this.SizeInches, this.SizeCentimeters, this.Resolution.Item1, this.Resolution.Item2,
                this.GraphicsDisplayResolution, this.Details);
        }

        #endregion
    }
}
