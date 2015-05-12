using System;
class StringLength
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        string editedString = String.Empty;
        if (inputString.Length < 20)
        {
            editedString = inputString.PadRight(20, '*');
        }
        else
        {
            editedString = inputString.Substring(0, 20);
        }

        Console.WriteLine(editedString);
    }
}

