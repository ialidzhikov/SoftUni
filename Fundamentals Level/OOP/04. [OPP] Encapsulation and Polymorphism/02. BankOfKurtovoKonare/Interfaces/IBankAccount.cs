using BankOfKurtovoKonare.Enumerations;

namespace BankOfKurtovoKonare.Interfaces
{
    public interface IBankAccount
    {
        CustomerType CustomerType { get; }

        decimal Balance { get; }

        double InterestRate { get; }

        void DepositeMoney(decimal depositeAmount);

        double CalculateInterest(int months);
    }
}
