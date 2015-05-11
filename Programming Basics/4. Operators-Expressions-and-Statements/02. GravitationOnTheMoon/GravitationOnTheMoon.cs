using System;
class GravitationOnTheMoon
{
    static void Main()
    {
        double weightOnEarth = double.Parse(Console.ReadLine());

        double weightOnMoon = weightOnEarth * (17d / 100d);

        Console.WriteLine(weightOnMoon);
    }
}

