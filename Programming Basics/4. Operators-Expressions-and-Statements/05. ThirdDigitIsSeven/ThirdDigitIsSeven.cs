using System;
class ThirdDigitIsSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isSeven = false;

        if ((number / 100) % 10 == 7)
        {
            isSeven = true;
        }

        Console.WriteLine(isSeven ? "true" : "false");
    }
}

