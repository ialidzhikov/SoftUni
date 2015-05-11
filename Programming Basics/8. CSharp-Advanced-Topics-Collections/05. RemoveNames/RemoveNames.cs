using System;
using System.Text;
class RemoveNames
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        string[] firstNames = firstInput.Split(' ');
        string[] secondNames = secondInput.Split(' ');

        bool isRepeated = false;
        StringBuilder removed = new StringBuilder();

        for (int i = 0; i < firstNames.Length; i++)
		{
            isRepeated = false;
            for (int j = 0; j < secondNames.Length; j++)
            {
                if (firstNames[i] == secondNames[j])
                {
                    isRepeated = true;
                    break;
                }
            }
            if (!isRepeated)
            {
                removed.AppendFormat("{0} ", firstNames[i]);
            }
		}

        Console.WriteLine(removed.ToString());
    }
}

