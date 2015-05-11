using System;
class NumberComparer
{
    static void Main()
    {
        double firsNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        
        Console.WriteLine(firsNumber > secondNumber ? firsNumber : secondNumber);
    }
}

