using System;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySpotList = new ColoredSpots(100);
            Console.WriteLine(mySpotList);

            mySpotList.Sort();
            Console.WriteLine(mySpotList);

            for (SpotColor col = SpotColor.Red; col <= SpotColor.White; col++)
            {
                Console.WriteLine($"There are {mySpotList.Count(col)} number of {col} spots");
            }

            #region Kata4 applied on Kata1
            var majorList = ColoredSpots.ClassFactory.CreateColoredSpotsList(5);
            foreach (var item in majorList)
            {
                Console.WriteLine();
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
