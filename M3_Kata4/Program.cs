using System;

namespace M3_Kata4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata3 portion
            Console.WriteLine("Kata3 portion");
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

            //Kata4 portion
            Console.WriteLine("\nKata4 portion");
            var listOfSpottedDates = VariousDates.ClassFactory.CreateVariousDateList(5);

            int i = 1;
            foreach (var item in listOfSpottedDates)
            {
                Console.WriteLine($"\nSpottedDate nr {i++}:");
                Console.WriteLine(item);
            }        
        }
    }
}
