using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;

        Console.WriteLine("Before the exchange: \nfirstValue = {0} \nsecondValue = {1}", firstValue, secondValue);
        
        //First variant
        int temp = firstValue;
        firstValue = secondValue;
        secondValue = temp;

        //Second variant
        /*firstValue = firstValue + secondValue;
        secondValue = firstValue - secondValue;
        firstValue = firstValue - secondValue;*/

        Console.WriteLine("After the exchange: \nfirstValue = {0} \nsecondValue = {1}", firstValue, secondValue);
    }
}

