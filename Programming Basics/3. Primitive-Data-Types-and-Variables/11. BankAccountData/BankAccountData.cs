using System;
class BankAccountData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string middleName = Console.ReadLine();
        string lastName = Console.ReadLine();
        decimal balance = decimal.Parse(Console.ReadLine());
        string bankName = Console.ReadLine();
        string IBAN = Console.ReadLine();
        ulong firstCreditCardNumber = ulong.Parse(Console.ReadLine());
        ulong secondCreditCardNumber = ulong.Parse(Console.ReadLine());
        ulong thirdCreditCardNumber = ulong.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}\nBalance: {3}\nIBAN: {4}\nFirst credit card number: {5}",
            firstName, middleName, lastName, balance, IBAN, firstCreditCardNumber);
        Console.WriteLine("Second credit card number: {0}\nThird credit card: {1}", secondCreditCardNumber, thirdCreditCardNumber);
    }
}

