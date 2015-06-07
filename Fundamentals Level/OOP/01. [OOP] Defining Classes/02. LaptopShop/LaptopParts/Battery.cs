using System;

namespace LaptopParts
{
    public class Battery
    {
        #region Fields

        private string type;
        private int numberOfCells;
        private double strength;
        private double life;

        #endregion

        #region Constructors

        public Battery(string type, int numberOfCells, double strength, double life)
        {
            this.Type = type;
            this.NumberOfCells = numberOfCells;
            this.Strength = strength;
            this.Life = life;
        }

        #endregion

        #region Properties

        public string Type
        {
            get { return this.type; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The battery type cannot be null, empty or whitespace.");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public int NumberOfCells
        {
            get { return this.numberOfCells; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of cells of a battery sould be greater than zero.");
                }
                else
                {
                    this.numberOfCells = value;
                }
            }
        }

        public double Strength
        {
            get { return this.strength; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery strength cannot be less than zero.");
                }
                else
                {
                    this.strength = value;
                }
            }
        }

        public double Life
        {
            get { return this.life; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The battery life should be positive.");
                }
                else
                {
                    this.life = value;
                }
            }
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return string.Format("{0}, {1}-cells, {2} mAh",
                this.Type, this.NumberOfCells, this.Strength);
        }

        #endregion
    }
}
