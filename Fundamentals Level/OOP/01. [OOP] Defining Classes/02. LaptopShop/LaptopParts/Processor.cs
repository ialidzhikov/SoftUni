using System;

namespace LaptopParts
{
    public class Processor
    {
        #region Fields

        private string model;
        private int numberOfCores;
        private Tuple<double, double> frequencies;
        private int cache;

        #endregion

        #region Constructors

        public Processor(string model, int numberOfCores, Tuple<double, double> frequencies)
            : this(model, numberOfCores, frequencies, 0)

        {
            
        }

        public Processor(string model, int numberOfCores, Tuple<double, double> frequencies, int cache)
        {
            this.Model = model;
            this.NumberOfCores = numberOfCores;
            this.Frequencies = frequencies;
            this.Cache = cache;
        }


        #endregion


        #region Properties

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The model of the processor cannot be null, empty or whitespace.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public int NumberOfCores
        {
            get { return this.numberOfCores; }
            set
            {
                if (value < 1 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("The number of cores of a processor should be in the range [1..20].");
                }
                else
                {
                    this.numberOfCores = value;
                }
            }
        }

        public Tuple<double, double> Frequencies
        {
            get { return this.frequencies; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The frequencies cannot be null.");
                }
                else if (value.Item1 < 0 || value.Item2 < 0)
                {
                    throw new ArgumentOutOfRangeException("The frequencies should be positive.");
                }
                else
                {
                    this.frequencies = value;
                }
            }
        }

        public int Cache
        {
            get { return this.cache; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The cache should be a positive number.");
                }
                else
                {
                    this.cache = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            if (this.Cache != 0)
            {
                return String.Format("{0} ({1}-core, {2:F2} - {3:F2} GHz, {4}MB cache)", 
                    this.Model, this.NumberOfCores, this.Frequencies.Item1, this.Frequencies.Item2, this.Cache);
            }
            else
            {
                return String.Format("{0} ({1}-core, {2:F2} - {3:F2} GHz, (no information fo cache))",
                    this.Model, this.NumberOfCores, this.Frequencies.Item1, this.Frequencies.Item2);    
            }
        }

        #endregion
    }
}
