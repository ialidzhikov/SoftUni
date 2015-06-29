using System;
using BankOfKurtovoKonare.Enumerations;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.BankAccounts
{
    class DepositAccount : BankAccount, IDepositeAccount
    {
        private readonly Tuple<int, int> RangeToInterestValidation = new Tuple<int,int>(0, 1000);

        public DepositAccount(CustomerType customerType, decimal balance, double interestRate)
            : base(customerType, balance, interestRate)
        {
            
        }

        public void WithdrawMoney(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance > RangeToInterestValidation.Item1 && this.Balance < RangeToInterestValidation.Item2)
            {
                throw new InvalidOperationException(
                    string.Format("The deposit accounts have no interest when the balance is in the range [{0}..{1}].",
                    RangeToInterestValidation.Item1, RangeToInterestValidation.Item2));
            }
            else
            {
                return base.CalculateInterest(months);
            }
        }
    }
}
