namespace BankOfKurtovoKonare.Interfaces
{
    public interface IDepositeAccount : IBankAccount
    {
        void WithdrawMoney(decimal withdrawAmount);
    }
}
