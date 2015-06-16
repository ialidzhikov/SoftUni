using System;
using Interfaces;

namespace Sales
{
    public class Sale : ISale
    {
        #region Fields

        private string productName;
        private DateTime date;
        private double price;

        #endregion

        #region Constructors

        public Sale(string productName, DateTime date, double price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        #endregion

        #region Properties

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The product name cannot be null, empty or whitespace.");
                }
                else
                {
                    this.productName = value;
                }
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative.");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10:dd/MM/yyyy} {2,-5:C2}", this.ProductName, this.Date, this.Price);
        }

        #endregion
    }
}
