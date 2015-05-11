using System;
class JoroTheFootballPlayer
{
    const int WEEKENDS = 52;
    static void Main()
    {
        string year = Console.ReadLine();
        double holidays = double.Parse(Console.ReadLine());
        double hometownWeekends = double.Parse(Console.ReadLine());

        double normalWeekedns = WEEKENDS - hometownWeekends;
        double plays = normalWeekedns * (2.0 / 3.0) + holidays * 0.5 + hometownWeekends;

        if (year == "t")
        {
            plays += 3;
        }

        Console.WriteLine("{0}", Math.Floor(plays));
    }
}

