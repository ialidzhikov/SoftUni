using System;

namespace FractionCalculator
{
    class FractionCalculator
    {
        static void Main()
        {
            Fraction fractionOne = new Fraction(22, 7);
            Fraction fractionTwo = new Fraction(40, 4);
            Fraction addition = fractionOne + fractionTwo;
            Console.WriteLine(addition.Numerator);
            Console.WriteLine(addition.Denominator);
            Console.WriteLine(addition);
        }
    }
}
