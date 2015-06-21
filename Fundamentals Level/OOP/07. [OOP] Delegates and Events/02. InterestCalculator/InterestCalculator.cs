using System;
using InterestCalculatorTest;

namespace InterestCalculatorClass
{
    public class InterestCalculator
    {
        public InterestCalculator(double money, double interest, int years, CalculateInterest CalculateInterest)
        {
            this.Money = money;
            this.Interest = interest / 100;
            this.Years = years;
            this.InterestResult = CalculateInterest(this.Money, this.Interest, this.Years);
        }

        public double Money { get; set; }

        public double Interest { get; set; }

        public int Years { get; set; }

        public double InterestResult { get; set; }

        public override string ToString()
        {
            return this.InterestResult.ToString("F4");
        }
    }
}
