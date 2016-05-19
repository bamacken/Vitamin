using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;

namespace Vitamin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input 
            int[] input = { 59, 27, 0, 57, 46, 80, 48, 32, 86, 23, 19, 13, 93, 42, 41, 26, 33, 90, 12, 22 };

            Sort sort = new Sort();

            Console.WriteLine("\nBubbleSort:");
            Shuffle(input, input.Length);
            sort.BubbleSort(input, input.Length);
            Print(input, "Output: ");

            Console.WriteLine("\nSelectionSort:");
            Shuffle(input, input.Length);
            sort.SelectionSort(input, input.Length);
            Print(input, "Output: ");

            Console.WriteLine("\nInsertionSort:");
            Shuffle(input, input.Length);
            sort.InsertionSort(input, input.Length);
            Print(input, "Output: ");

            Console.WriteLine("\nQuickSort:");
            Shuffle(input, input.Length);
            sort.QuickSort(input, 0, input.Length - 1);
            Print(input, "Output: ");

            Search search = new Search();
            int value = search.Binary(input, input.Length, 80);
            if (value > -1)
            {
                Console.WriteLine("Value found at index: " + value);
            }
            value = search.Sequential(input, input.Length, 80);
            if (value > -1)
            {
                Console.WriteLine("Value found at index: " + value);
            }
            Console.ReadLine();
        }

        static void Print(int[] a, string msg)
        {
            StringBuilder b = new StringBuilder();
            b.Append(msg);

            for (int i = 0; i < a.Length; i++)
            {
                b.Append(a[i]);
                if (i < a.Length - 1)
                {
                    b.Append(", ");
                }
            }
            Console.WriteLine(b.ToString());
        }

        /// <summary>
        /// Fisher–Yates shuffle
        /// </summary>
        /// <param name="input"></param>
        /// <param name="count"></param>
        static void Shuffle(int[] input, int count)
        {
            Random rand = new Random();
            int value;
            for (int i = 0; i < count; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                int r = i + (int)(rand.NextDouble() * (count - i));
                value = input[r];
                input[r] = input[i];
                input[i] = value;
            }
            Print(input, "Input: ");
        }
    }
}
