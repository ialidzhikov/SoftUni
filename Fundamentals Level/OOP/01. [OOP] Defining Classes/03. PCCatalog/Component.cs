using System;

namespace Component
{
    public enum ComponentName
    {
        Motherboard,
        Processor,
        HardDisk,
        RAM,
        GraphicsCard,
    };

    class Component
    {
        #region Fields

        private ComponentName name;
        private string details;
        private double price;

        #endregion

        #region Constructors

        public Component(ComponentName name, double price) : this(name, null, price)
        {
            
        }

        public Component(ComponentName name, string details, double price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        #endregion



        #region Properties

        public ComponentName Name
        {
            get { return this.name; }
            set
            {
                if (!ComponentName.TryParse(value.ToString(), true, out this.name))
                {
                    throw new ArgumentException(String.Format("Cannot parse {0} to {1}", value.GetType().Name, "ComponentName"));
                }
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value != null)
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("The details of a component cannot be empty or whitespace.");
                    }
                    else
                    {
                        this.details = value;
                    }
                }
            }
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
            return String.Format("{0,-16} {1,-20} {2,-5:C2}", this.Name, this.Details ?? "(no data)", this.Price);
        }

        #endregion
    }
}
