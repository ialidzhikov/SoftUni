using System;

namespace BitArray
{
    public class BitArray
    {
        #region Fields

        private const int MinSize = 1;
        private const int MaxSize = 100000;

        private byte[] bits;
        private int size;

        #endregion

        #region Constructors

        public BitArray(int size)
        {
            this.Size = size;
            this.Bits = new byte[this.Size];
        }

        #endregion

        #region Properties

        public byte[] Bits
        {
            get { return this.bits; }
            protected set { this.bits = value; }
        }

        public int Size
        {
            get { return this.size; }
            protected set
            {
                if (value < MinSize || value > MaxSize)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The size should be in the range [{0}..{1}]", MinSize,  MaxSize));
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
            return ConvertToDecimal().ToString();
        }

        private ulong ConvertToDecimal()
        {
            ulong decimalNumber = 0L;
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Bits[i] == 1)
                {
                    decimalNumber += (ulong)Math.Pow(2, i);
                }
            }
            return decimalNumber;
        }

        #endregion

        #region Operators

        public byte this[int index]
        {
            get
            {
                if (index < MinSize || index > MaxSize)
                {
                    throw new IndexOutOfRangeException("The index should be in the range [{0}..{1}].");
                }
                else
                {
                    return this.Bits[index];
                }
            }
            set
            {
                if (index < MinSize || index > MaxSize)
                {
                    throw new IndexOutOfRangeException("The index should be in the range [{0}..{1}].");
                }
                else if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("The bit value must be 0 or 1.");
                }
                else
                {
                    this.Bits[index] = value;
                }
            }
        }

        #endregion

        static void Main()
        {
            BitArray bitArray = new BitArray(8);
            bitArray[7] = 1;
            Console.WriteLine(bitArray);
        }
    }
}
