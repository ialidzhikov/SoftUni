using System;
using BankOfKurtovoKonare.Enumerations;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.BankAccounts
{
    class LoanAccount : BankAccount, ILoanAccount
    {
        private const int RequiredMonthsForIndividuals = 3;
        private const int RequiredMonthsForCompanies = 2;

        public LoanAccount(CustomerType customerType, decimal balance, double interestRate)
            : base(customerType, balance, interestRate)
        {
            
        }

        public override double CalculateInterest(int months)
        {
            if (months <= RequiredMonthsForIndividuals && this.CustomerType.Equals(CustomerType.Individual))
            {
                throw new InvalidOperationException(string.Format("Loan accounts have no interest in the first {0} months for individuals.",
                    RequiredMonthsForIndividuals));
            }
            else if (months <= RequiredMonthsForCompanies && this.CustomerType.Equals(CustomerType.Company))
            {
                throw new InvalidOperationException(string.Format("Loan accounts have no interest in the first {0} months for companies.",
                    RequiredMonthsForCompanies));
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
