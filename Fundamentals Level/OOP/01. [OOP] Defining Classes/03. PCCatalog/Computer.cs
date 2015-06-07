using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computer
{
    using Component;
    class Computer
    {
        #region Fields

        private string name;
        private IList<Component> components;
        private double price;

        #endregion

        #region Properties

        #region Constructors

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.Price = this.Components.Select(component => component.Price).Sum();
        }

        #endregion

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name of a computer cannot be null, empty ot whitespace.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public IList<Component> Components
        {
            get { return this.components; }
            set { this.components = value; }
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
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("{0}{1}", this.Name, Environment.NewLine);
            foreach (Component component in this.Components)
            {
                toString.AppendFormat("{0}{1}", component.ToString(), Environment.NewLine);
            }
            toString.AppendFormat("Total computer price: {0:C2}", this.Price);
            return toString.ToString();
        }

        #endregion
    }
}
