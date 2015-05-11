using System;
class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());

        int resultCount = 0;

        for (int firstNumber = 100; firstNumber <= 777; firstNumber++)
        {
            int secondNumber = firstNumber + diff;
            int thirdNumber = secondNumber + diff;

            if (CheckSumOfDigits(firstNumber, secondNumber, thirdNumber, sum) && CheckRange(firstNumber) && thirdNumber <= 777 
                && CheckRange(secondNumber) && CheckRange(thirdNumber))
            {
                Console.WriteLine("{0}{1}{2}", firstNumber, secondNumber, thirdNumber);
                resultCount++;
            }
        }

        if (resultCount == 0)
        {
            Console.WriteLine("No");
        }
    }
    static bool CheckRange(int number)
    {
        string numberInString = number.ToString();
        foreach (var digit in numberInString)
        {
            if ((char)digit < 49 || (char)digit > 55)
            {
                return false;
            }
        }
        return true;
    }
    static bool CheckSumOfDigits(int firstNumber, int secondNumber, int thirdNumber, int sum)
    {
        int sumOfDigits = FindSumOfDigits(firstNumber) + FindSumOfDigits(secondNumber) + FindSumOfDigits(thirdNumber);
        if (sumOfDigits == sum)
        {
            return true;
        }
        return false;
    }

    static int FindSumOfDigits(int number)
    {
        int sum = 0;
        string numberInString = number.ToString();
        foreach (var digit in numberInString)
        {
            sum += int.Parse(digit.ToString());
        }
        return sum;
    }
}

