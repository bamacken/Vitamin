using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Sort
    {
        /// <summary>
        /// Selection Sort, Worst case O of n-squared
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public void SelectionSort(int[] items, int count)
        {
            int i, j, k, value;
            //loop through every element (n-1)
            for (i = 0; i < count; ++i)
            {
                //store the first element
                k = i;
                value = items[i];

                //loop through remaining elements (1/2n) 
                for (j = i + 1; j < count; ++j)
                {
                    //finding selecting the lowest value less than the store value
                    if (items[j] < value)
                    {
                        k = j;
                        value = items[k];
                    }
                }
                //exchange the lowest value with the first stored value
                items[k] = items[i];
                items[i] = value;
            }
        }

        /// <summary>
        /// QuickSort:
        /// Average case: O of n log n | WORST CASE: O of n-squared
        /// </summary>
        /// <param name="items"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public void QuickSort(int[] items, int left, int right)
        {
            int i, j, x, y;

            //store the leftmost and right most index
            i = left;
            j = right;
            //grab the middle element value
            x = items[(left + right) / 2];
            do
            {
                //loop over left segment and compare with the center value 
                //until we find a value that greater than the center value
                while (items[i] < x && i < right)
                {
                    i++;
                }
                //loop over right segment and compare with the center value 
                //until we find a value that less than the center value
                while (x < items[j] && j > left)
                {
                    j--;
                }

                if (i <= j)
                {
                    //if both while conditions are false we know that the 
                    //the elements chould be exchanged
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j)
            {
                QuickSort(items, left, j);
            }

            if (i < right)
            {
                QuickSort(items, i, right);
            }
        }

        /// <summary>
        /// InsertionSort, worst case: O of n-squared
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public void InsertionSort(int[] items, int count)
        {
            int i, j, value;
            //loop through every element (n-1)
            for (i = 1; i < count; ++i)
            {
                //store the first element
                value = items[i];
                j = i - 1;
                while (j >= 0 && value < items[j])
                {
                    items[j + 1] = items[j];
                    j--;
                }
                items[j + 1] = value;
            }
        }

        /// <summary>
        /// BubbleSort: WORST CASE: O of n-squared, for each input, loop over each input and exchange
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public void BubbleSort(int[] items, int count)
        {
            int i, j, c;
            //loop through every element 1 to n (n-1)
            for (i = 1; i < count; ++i)
            {
                //loop through every element n to 1 (n-1)
                for (j = count - 1; j >= i; --j)
                {
                    //exchange elements if current less than leftmost value 
                    // bubbling of lowest value to the top
                    if (items[j - 1] > items[j])
                    {
                        c = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = c;
                    }
                }
            }
        }

        /// <summary>
        /// comment sorting algorithm here :)
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public void HeapSort(int[] items, int count)
        {

        }

        /// <summary>
        /// Comment and sort algorithm coming soon
        /// </summary>
        /// <param name="items"></param>
        /// <param name="count"></param>
        public void MergeSort(int[] items, int count)
        {

        }
    }
}

