using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Search
    {
        /// <summary>
        /// Sequential search used for un-sorted data. O of n
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Sequential(int[] items, int count, int key)
        {
            Console.WriteLine("\nSequential Search: ");

            int i;
            for (i = 0; i < items.Length; i++)
            {
                if (key == items[i])
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Binary search used for ordered data. Worst case and average case is "O of log n", best case is linear "O of 1"
        /// </summary>
        public int Binary(int[] items, int count, int key)
        {
            Console.WriteLine("\nBinary Search: ");

            int low, high, mid;
            low = 0;
            high = count - 1;

            for (int i = 0; i < items.Length; i++)
            {
                mid = (low + high) / 2;
                if (key < items[mid])
                    high = mid - 1;
                else if (key > items[mid])
                    low = mid + 1;
                else if (key == items[mid])
                    return mid;
            }
            return -1;
        }
    }
}
