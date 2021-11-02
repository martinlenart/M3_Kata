using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Kata2
{
    class VariousDates : IVariousDates
    {
        List<DateTime> _myDates = new List<DateTime>();

        public DateTime this[int idx] => _myDates[idx];
        public int Count(int month)
        {
            int count = 0;
            foreach (var item in _myDates)
            {
                if (item.Month == month)
                    count++;
            }
            return count;
        }
        public int Count() => _myDates.Count;
        public void Sort() => _myDates.Sort();
 
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < _myDates.Count; i++)
            {
                sRet += $"{_myDates[i]:d}  ";
                
                if ((i + 1) % 5 == 0)
                    sRet += $"\n";
            }

            return sRet;
        }
        public VariousDates (int NrOfDates)
        {
            var rnd = new Random();

            for (int i = 0; i < NrOfDates; i++)
            {
                try
                {
                    _myDates.Add(DateTime.Parse($"{rnd.Next(2000, 2022)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}"));
                }
                catch
                {
                    i--;
                }
            }
        }
    }
}
