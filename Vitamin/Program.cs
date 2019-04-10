using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;
using DataStructure;

namespace Vitamin
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList
            LinkedList list = new LinkedList(); // Init Linked list
            list.InsertNode("4"); // Add Node
            list.InsertNode("5"); // Add Node
            list.InsertNode("6"); // Add Node
            list.InsertNode("3"); // Add Node
            list.InsertNode("7"); // Add Node
            list.InsertNode("2"); // Add Node
            list.InsertNode("8"); // Add Node
            list.InsertNode("1"); // Add Node
            list.InsertNode("0"); // Add Node

            list.Delete("0"); // Remove Node
            list.Delete("7"); // Remove Node
            list.Delete("2"); // Remove Node
            list.Delete("8"); // Remove Node

            Node node6 = list.Traverse("6"); // Retrieve Node
            Node node3 = list.Traverse("3"); // Retrieve Node

            //Hashtable test
            // create isntance
            Hashtable hash = new Hashtable(300);

            
            // add to table
            hash.Insert("Bryan", 43);
            hash.Insert("Maddy", 30);
            hash.Insert("Charlie", 9);
            hash.Insert("Bob", 50);
            hash.Insert("Ryan", 50);
            hash.Insert("Bryant", 50);

            // remove from table
            hash.remove("Bryan");

            // Sort search Input data
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
