using System;

namespace LaptopParts
{
    public class HardDisk
    {
        #region Fields

        private string type;
        private int size;

        #endregion

        #region Constructors

        public HardDisk(string type, int size)
        {
            this.Type = type;
            this.Size = size;
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
                    throw new ArgumentException("The type of a hard disk cannot be null, empty or whitespace.");
                }
                else
                {
                    this.type = value;
                }
            }
        }

        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The size of a hard disk sould be positive number.");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return String.Format("{0}GB {1}", this.Size, this.Type);
        }

        #endregion
    }
}
