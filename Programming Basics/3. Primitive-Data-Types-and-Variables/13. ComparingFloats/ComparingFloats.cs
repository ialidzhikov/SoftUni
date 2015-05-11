using System;
class ComparingFloats
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double epsilon = 0.000001f;
        double difference = Math.Abs(firstNumber - secondNumber);

        if (difference < epsilon)
        {
            Console.WriteLine("Numbers are equal.");
        }
        else
        {
            Console.WriteLine("Numbers are not equal.");
        }
    }
}

