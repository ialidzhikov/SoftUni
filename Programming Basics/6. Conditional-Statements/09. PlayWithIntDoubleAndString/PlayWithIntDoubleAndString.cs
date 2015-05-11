using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine(++inputInt);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(++inputDouble);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString + '*');
                break;
            default:
                Console.WriteLine("Error");
                break;
        }
    }
}

