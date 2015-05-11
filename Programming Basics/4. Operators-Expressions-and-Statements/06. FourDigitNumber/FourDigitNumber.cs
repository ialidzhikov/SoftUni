using System;
class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        CalculateSumOfDigits(number);
        PrintNumberInReverse(number);
        PutLastDigitInFirstPosition(number);
        ExchangeSecondAndThirdDigits(number);
    }

    private static void ExchangeSecondAndThirdDigits(int number)
    {
        int firstDigit = number % 10;
        int secondDigit = (number / 10) % 10;
        int thirdDigit = (number / 100) % 10;
        int fourtDigit = number / 1000;

        int newNumber = fourtDigit * 1000 + thirdDigit * 10 + secondDigit * 100 + firstDigit;

        Console.WriteLine(newNumber);
    }

    private static void PutLastDigitInFirstPosition(int number)
    {
        int lastDigit = number % 10;
        number /= 10;
        int newNumber = number + (lastDigit * 1000);

        Console.WriteLine(newNumber);
    }

    private static void PrintNumberInReverse(int number)
    {
        int newNumber = 0;
        int i = 1000;

        while (number != 0)
        {
            newNumber += (number % 10) * i;
            number /= 10;
            i /= 10;
        }

        Console.WriteLine(newNumber);
    }

    private static void CalculateSumOfDigits(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine(sum);
    }
}

