using System;
class DivideByFiveAndSeven
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isDivisible = false;

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            isDivisible = true;
        }

        Console.WriteLine(isDivisible ? "true" : "false");
    }
}

