using System;
class DeclareVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        uint thirdNumber = 4825932;
        byte fourthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("First number - {0} ({1})", firstNumber, firstNumber.GetType());
        Console.WriteLine("Second number - {0} ({1})", secondNumber, secondNumber.GetType());
        Console.WriteLine("Third number - {0} ({1})", thirdNumber, thirdNumber.GetType());
        Console.WriteLine("Fourth number - {0} ({1})", fourthNumber, fourthNumber.GetType());
        Console.WriteLine("Fifth number - {0} ({1})", fifthNumber, fifthNumber.GetType());
    }
}

