using System;
using System.Collections.Generic;

namespace M3_Kata4
{
    class VariousDates : IVariousDates
    {
        List<SpotDate> _itemList = new List<SpotDate>();
        public int Count(int month)
        {
            int c = 0;
            foreach (var item in _itemList)
            {
                if (item.date.Month == month)
                    c++;
            }
            return c;
        }

        public bool Find(int month)
        {
            foreach (var item in _itemList)
            {
                if (item.date.Month == month)
                    return true;
            }
            return false;
        }

        public int Count() => _itemList.Count;

        public void Sort() => _itemList.Sort();

        public SpotDate this[int idx] => _itemList[idx];

        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _itemList.Count; i++)
            {
                sRet += $"{_itemList[i]} ";

                if ((i + 1) % 5 == 0)
                    sRet += "\n";
            }
            return sRet;
        }

        public VariousDates(int NrOfItems)
        {
            var rnd = new Random();
            for (int i = 0; i < NrOfItems; i++)
            {
                try
                {
                    SpotColor color = (SpotColor)rnd.Next((int)SpotColor.Red, (int)SpotColor.White + 1);
                    int year = rnd.Next(2000, 2022);
                    int month = rnd.Next(1, 13);
                    int day = rnd.Next(1, 32);

                    _itemList.Add(new SpotDate
                    {
                        date = new DateTime(year, month, day),
                        spotColor = color
                    });
                }
                catch
                {
                    i--;
                }
            }
        }

        public static class ClassFactory
        {
            public static List<VariousDates> CreateVariousDateList (int NrOfItems)
            {
                var rnd = new Random();
                List<VariousDates> retList = new List<VariousDates>();
                for (int i = 0; i < NrOfItems; i++)
                {
                    retList.Add(new VariousDates(rnd.Next(1, 51)));
                }

                return retList;
            }
        }
    }
}
