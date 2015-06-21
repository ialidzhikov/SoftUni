using System;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsynchronousTimer
    {
        static void Main()
        {
            AsyncTimer asyncTimer = new AsyncTimer(PrintTime, 10, 2000);
            Task startTimer = asyncTimer.StartTimer();

            Console.WriteLine("The task is completing, spam here: ");

            while (startTimer.IsCompleted == false)
            {
                Console.ReadLine(); 
            }

            Console.WriteLine("The task has been completed!");
        }

        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
