using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata1
{
    class ColoredSpots : IColoredSpots
    {
        List<SpotColor> mySpots = new List<SpotColor>();

        public int Count(SpotColor color)
        {
            int count = 0;
            foreach (var item in mySpots)
            {
                if (item == color)
                    count++;
            }
            return count;
        }

        public void Sort()
        {
            mySpots.Sort();
        }

        public override string ToString()
        {
            string sRet = "";
            /*
            int cntr = 0;
            foreach (var item in mySpots)
            {
                sRet += $"{item, -5} ";
                cntr++;

                if (cntr % 10 == 0)
                    sRet += "\n";
            }
            */

            for (int i = 0; i < mySpots.Count; i++)
            {
                sRet += $"{mySpots[i],-10} ";
                if ((i+1) % 10 == 0)
                    sRet += "\n";
            }

            return sRet;
        }

        public ColoredSpots (int NumberOfSpots)
        {
            var rnd = new Random();
            for (int i = 0; i < NumberOfSpots; i++)
            {
                SpotColor col = (SpotColor) rnd.Next((int)SpotColor.Red, (int)SpotColor.White + 1);
                mySpots.Add(col);
            }
        }
    }
}

/*
3. Implementera IColoredSpots i en class, ColoredSpots
4. I ColoredSpots
	- enksulera och Skapa en lista av SpotColor
	- I constructorn skapa ett antal element i listan av random färg
	- Override ToString() för att skriva ColoredSpots
	- Implementera Count och Sort
 */
