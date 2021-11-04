using System;

namespace M3_Kata3
{
    class Program
    {
        static void Main(string[] args)
        {
            IVariousDates mySpottedDates = new VariousDates(100);
            Console.WriteLine(mySpottedDates);

            Console.WriteLine($"Sorted {mySpottedDates.Count()} dates!");
            mySpottedDates.Sort();
            Console.WriteLine(mySpottedDates);

            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine($"Month nr {month} constains {mySpottedDates.Count(month)} dates.");
            }

            Console.WriteLine($"\nmySpottedDates[0]: {mySpottedDates[0]}");

        }
    }
}
