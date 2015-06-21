using System;
using InterestCalculatorClass;

namespace InterestCalculatorTest
{
    public delegate double CalculateInterest(double sum, double interest, int years);
    public class InterestCalculatorTest
    {
        private const int CompoundingTimesPerYear = 12;

        static void Main()
        {
            CalculateInterest simpleInterestDelegate = GetSimpleInterest;
            CalculateInterest comInterestDelegate = GetCompoundInterest;


            InterestCalculator compoundInterestCalculator = new InterestCalculator(500, 5.6, 10, comInterestDelegate);
            InterestCalculator simpleInterestCalculator = new InterestCalculator(2500, 7.2, 15, simpleInterestDelegate);

            Console.WriteLine(compoundInterestCalculator);
            Console.WriteLine(simpleInterestCalculator);
        }

        public static double GetSimpleInterest(double sum, double interest, int years)
        {
            return Math.Round(sum * (1 + interest * years), 4);
        }

        public static double GetCompoundInterest(double sum, double interest, int years)
        {
            return Math.Round(sum * Math.Pow(1 + interest / CompoundingTimesPerYear, years * CompoundingTimesPerYear), 4); 
        }
        
    }
}
