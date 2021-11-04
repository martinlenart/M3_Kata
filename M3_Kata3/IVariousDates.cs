using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Kata3
{
    public enum SpotColor { Red, Green, Blue, Orange, White }
    public class SpotDate : IComparable<SpotDate>
    {
        public DateTime date;
        public SpotColor spotColor;

        public int CompareTo(SpotDate other)
        {
            if (spotColor != other.spotColor)
                return spotColor.CompareTo(other.spotColor);

            return date.CompareTo(other.date);
        }

        public override string ToString()
        {
            return $"{spotColor,8}/{date,-15:d}";
        }
    }
    interface IVariousDates
    {
        /// <summary>
        /// Count the numer of dates that falls withing a month, regardless of year
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public int Count(int month);

        /// <summary>
        /// Returns the total number of dates in the list
        /// </summary>
        /// <returns></returns>
        public int Count();

        /// <summary>
        /// Returns true if a month is in the list
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        public bool Find(int month);

        /// <summary>
        /// Sorts the dates in the list in ascending order
        /// </summary>
        public void Sort();

        SpotDate this[int idx] { get; }
    }
}
