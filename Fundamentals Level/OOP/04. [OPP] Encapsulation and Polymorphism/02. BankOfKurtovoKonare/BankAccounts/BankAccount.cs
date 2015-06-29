using System;
using BankOfKurtovoKonare.Enumerations;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.BankAccounts
{
    abstract class BankAccount : IBankAccount
    {
        #region Fields

        private CustomerType customerType;
        private decimal balance;
        private double interestRate;

        #endregion

        #region Constructors

        protected BankAccount(CustomerType customerType, decimal balance, double interestRate)
        {
            this.CustomerType = customerType;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        #endregion

        #region Properties

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            protected set { this.customerType = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            protected set { this.interestRate = value; }
        }

        #endregion

        #region Methods

        public void DepositeMoney(decimal depositeAmount)
        {
            this.Balance += depositeAmount;
        }

        public virtual double CalculateInterest(int months)
        {
            return (double)this.Balance * (1 + this.InterestRate * months);
        }

        public override string ToString()
        {
            return string.Format("Type: {0,-10} Balance: {1:C2} Interest rate: {2:F1}",
                this.CustomerType, this.Balance, this.InterestRate);
        }

        #endregion
    }
}
