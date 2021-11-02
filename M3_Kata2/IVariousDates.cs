using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3_Kata2
{
    interface IVariousDates
    {
        /// <summary>
        /// Indexer to get a date at specific index in the internal list
        /// </summary>
        /// <param name="idx">index of DateTime element to return</param>
        /// <returns></returns>
        DateTime this[int idx] { get;}
        
        /// <summary>
        /// Will Sort the dates in ascending order
        /// </summary>
        void Sort();

        /// <summary>
        /// Count the number of dates in the list that fall within the specified month
        /// </summary>
        /// <param name="month">The month to count the nr of dates within</param>
        /// <returns></returns>
        int Count(int month);

        /// <summary>
        /// The number of total dates in the implementation
        /// </summary>
        /// <returns></returns>
        int Count();
    }
}
