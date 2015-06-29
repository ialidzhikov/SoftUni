using System;
using BankOfKurtovoKonare.BankAccounts;
using BankOfKurtovoKonare.Enumerations;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main()
        {
            IBankAccount[] bankAccounts = new IBankAccount[]
            {
                new LoanAccount(CustomerType.Company, 100000.23m, 4.5),
                new DepositAccount(CustomerType.Individual, 203.48m, 6.9),
                new DepositAccount(CustomerType.Company, 192.48m, 9),
                new DepositAccount(CustomerType.Individual, -20.48m, 6.2),
                new MortgageAccount(CustomerType.Individual, -6000.34m, -9),
                new DepositAccount(CustomerType.Individual, 0m, 6),
            };

            foreach (IBankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine("{0, -15} -> {1}", bankAccount.GetType().Name, bankAccount);
            }
        }
    }
}
