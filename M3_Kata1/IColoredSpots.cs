namespace Kata1
{
    public enum SpotColor { Red, Green, Blue, Orange, White }
    interface IColoredSpots
    {
        /// <summary>
        /// Counts the numer of spots with a color
        /// </summary>
        /// <param name="color">Color of spot</param>
        /// <returns></returns>
        public int Count(SpotColor color);

        /// <summary>
        /// Sort the Spots in order of Color
        /// </summary>
        public void Sort();
    }
}

//1. Deklarera en enum type SpotColor som innehåller färgerna Röd, Grön, Blå, Orange, Vit
//2. Deklarara ett Interface IColoredSpots som definierar
//	- Metod, Count, som räknar antalet spots av en viss färg i en lista 
//	- Metod, Sort, som sorterar spots i en lista efter färg
