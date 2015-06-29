using System;

namespace GenericList
{
    class GenericListTest
    {
        static void Main()
        {
            GenericList<string> genericList = new GenericList<string>()
            {
                "I", "You", "He", "She", "We", "They"
            };
            genericList.Add("Me");
            genericList.Add("Her");

            Console.WriteLine(genericList);
            Console.WriteLine();
            
            genericList.RemoveAt(2);
            Console.WriteLine("After removing at 2: ");
            Console.WriteLine(genericList);
            Console.WriteLine();

            Console.WriteLine("Accessing by index 3: {0}", genericList[3]);
            Console.WriteLine();

            genericList.InsertAt(4, "Inserted");
            Console.WriteLine("After inserting at 4:");
            Console.WriteLine(genericList);
            Console.WriteLine();

            Console.WriteLine("Find position of \"They\": {0}", genericList.Find("They"));
            Console.WriteLine();

            Console.WriteLine("Constains \"Her\": {0}", genericList.Contains("Her"));
            Console.WriteLine();
        }
    }
}
