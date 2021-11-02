using System;

namespace M3_Kata2
{
    class Program
    {
        static void Main(string[] args)
        {
            //IVariousDates myDates = null;
            IVariousDates dt1 = new VariousDates(100);
            Console.WriteLine($"Random {dt1.Count()} dates");
            Console.WriteLine(dt1);

            dt1.Sort();
            Console.WriteLine($"\nSorted {dt1.Count()} dates");
            Console.WriteLine(dt1);

            Console.WriteLine($"\ndt1[0]:  {dt1[0]:d}");
            Console.WriteLine($"dt1[last]:  {dt1[dt1.Count() - 1]:d}");

            for (int month = 1; month <= 12; month++)
            {
                Console.WriteLine($"There were {dt1.Count(month)} dates in month {month}");
            }
        }
    }
}
