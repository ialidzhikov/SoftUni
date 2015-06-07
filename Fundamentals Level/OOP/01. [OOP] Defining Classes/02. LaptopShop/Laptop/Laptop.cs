using System;
using System.Text;
using LaptopParts;

namespace Laptop
{
    public class Laptop
    {
        #region Fields

        private string model;
        private string manufacturer;
        private Processor processor;
        private int ramMemory;
        private string graphicsCard;
        private HardDisk hardDisk;
        private Screen screen;
        private Battery battery;
        private double price;

        #endregion

        #region Constructors

        public Laptop() : this(null, 0)
        {
            
        }

        public Laptop(string model, double price) : this(model, "(no data)", null, 0, "(no data)", null, price)
        {
            
        }

        public Laptop(string model, string manufacturer, Processor processor, int ramMemory, string graphicsCard, HardDisk hardDisk, double price)
            : this(model, manufacturer, processor, ramMemory, graphicsCard, hardDisk, null, null, price)
        {
            
        }

        public Laptop(string model, string manufacturer, Processor processor, int ramMemory, 
            string graphicsCard, HardDisk hardDisk, Screen screen, Battery battery, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RamMemory = ramMemory;
            this.GraphicsCard = graphicsCard;
            this.HardDisk = hardDisk;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        #endregion

        #region Properties

        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The model of a laptop cannot be null, empty or whitespace.");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The manufacturer of a laptop cannot be null, empty or whitespace.");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }


        public Processor Processor
        {
            get { return this.processor; }
            set
            {
                if (value != null)
                {
                    this.processor = value;
                }
            }
        }

        public int RamMemory
        {
            get { return this.ramMemory; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The RAM memory cannot be negative.");
                }
                else
                {
                    this.ramMemory = value;
                }
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The graphics card cannot be null, empty or whitespace.");
                }
                else
                {
                    this.graphicsCard = value;
                }
            }
        }

        public HardDisk HardDisk
        {
            get { return this.hardDisk; }
            set
            {
                if (value != null)
                {
                    this.hardDisk = value;   
                }
            }
        }

        public Screen Screen
        {
            get { return this.screen; }
            set
            {
                if (value != null)
                {                    
                    this.screen = value;
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                if (value != null)
                {
                    this.battery = value;
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
                    throw new ArgumentOutOfRangeException("The price of a laptop cannot be negative.");
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
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Model:", this.Model, Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Manufacturer:", this.Manufacturer ?? "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Processor:", this.Processor != null ? this.Processor.ToString() : "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "RAM:", (this.RamMemory != 0 ? this.RamMemory.ToString() + " GB": "(no data)"), Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Graphics card:", this.GraphicsCard ?? "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "HDD:", this.HardDisk != null ? this.HardDisk.ToString() : "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Screen:", this.Screen != null ? this.Screen.ToString() : "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Battery:", this.Battery != null ? this.Battery.ToString() : "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}{2}", "Battery life:",
                this.Battery != null ? this.Battery.Life.ToString() + " hours" : "(no data)", Environment.NewLine);
            toString.AppendFormat("{0,-16} {1,-30}", "Price:", String.Format("{0:F2} lv.", this.Price));

            return toString.ToString();
        }

        #endregion

    }
}
