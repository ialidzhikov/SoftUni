using System;

namespace FractionCalculator
{
    public struct Fraction
    {
        #region Fields

        private long numerator;
        private long denominator;

        #endregion

        #region Constructors

        public Fraction(long numerator, long denominator)
        {
            this.numerator = 0;
            this.denominator = 0;

            this.Numerator = numerator;
            this.Denominator = denominator;
            this.Cancel();
        }

        #endregion

        #region Properties

        public long Numerator
        {
            get { return this.numerator; }
            set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("The denominator cannot be zero.");
                }
                else
                {
                    this.denominator = value;
                }
            }
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return (this.Numerator / (decimal)this.Denominator).ToString();
        }

        private void Cancel()
        {
            long greatestCommonDivisor = FindGMD(this.Numerator, this.Denominator);
            if (greatestCommonDivisor != 1)
            {
                this.Numerator /= greatestCommonDivisor;
                this.Denominator /= greatestCommonDivisor;
            }
        }

        private static long FindGMD(long numerator, long denominator)
        {
            long remainder = 0;
            while (denominator != 0)
            {
                remainder = numerator % denominator;
                numerator = denominator;
                denominator = remainder;
            }
            return numerator;
        }

        private static long FindLCM(long denominatorOne, long denominatorTwo)
        {
            return (denominatorOne / FindGMD(denominatorOne, denominatorTwo)) * denominatorTwo;
        }

        #endregion

        #region Operators

        public static Fraction operator +(Fraction fractionOne, Fraction fractionTwo)
        {
            long leastCommonMultiple = FindLCM(fractionOne.Denominator, fractionTwo.Denominator);
            long additionNumerator = fractionOne.Numerator*(leastCommonMultiple/fractionOne.Denominator) +
                                     fractionTwo.Numerator*(leastCommonMultiple/fractionTwo.Denominator);

            return new Fraction(additionNumerator, leastCommonMultiple);
        }

        public static Fraction operator -(Fraction fractionOne, Fraction fractionTwo)
        {
            long leastCommonMultiple = FindLCM(fractionOne.Denominator, fractionTwo.Denominator);
            long subtractionNumerator = fractionOne.Numerator * (leastCommonMultiple / fractionOne.Denominator) -
                                     fractionTwo.Numerator * (leastCommonMultiple / fractionTwo.Denominator);

            return new Fraction(subtractionNumerator, leastCommonMultiple);
        }

        #endregion
    }
}
