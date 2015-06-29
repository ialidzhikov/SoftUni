using System;
using BankOfKurtovoKonare.Enumerations;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.BankAccounts
{
    class MortgageAccount : BankAccount, IMortgageAccount
    {
        private const int RequiredMonthForIndividuals = 6;
        private const int HalfInterestMonthsForCompanies = 12;

        public MortgageAccount(CustomerType customerType, decimal balance, double interestRate)
            : base(customerType, balance, interestRate)
        {
            
        }

        public override double CalculateInterest(int months)
        {
            if (months <= RequiredMonthForIndividuals && this.CustomerType.Equals(CustomerType.Individual))
            {
                throw new InvalidOperationException(string.Format("Mortgage accounts have no interest int the first {0} months for individuals.", 
                    RequiredMonthForIndividuals));
            }
            else if (months <= HalfInterestMonthsForCompanies && this.CustomerType.Equals(CustomerType.Company))
            {
                return base.CalculateInterest(months) / 2;
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
