using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstString = "Hello";
        string secondString = "World";
        object concatenation = firstString + " " + secondString;
        string thirdString = (string)concatenation;

        Console.WriteLine(concatenation);
        Console.WriteLine(thirdString);
    }
}

