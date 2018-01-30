using System;

namespace HomeworkFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // TODO: write code to ask for input array of numbers, then which number we want to find
            // and then output first and last occurrences into console

            Console.WriteLine("Enter your array of NUMBERS separated by spaces and hit ENTER");
            var line = Console.ReadLine().Split(' ');
            Console.WriteLine("Entered " + line.Length + " numbers");


            int[] items = new int[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                items[i] = Convert.ToInt32(line[i]);
            }

            Console.WriteLine("What number should I find?");
            int numberToFind = Convert.ToInt32(Console.ReadLine());

            int j = LastIntegerIndex(items, numberToFind);
            int l = FirstIntegerIndex(items, numberToFind);
            Console.WriteLine("First occurance: " + l);
            Console.WriteLine("Last occurance: " + j);

        }

        // TODO : Find index of first occurrence in integer array. Solve using loop of your choice.
        public static int LastIntegerIndex(int[] items, int numberToFind)
        {
            // TODO: Delete following line before implementing.
            for (int j = items.Length - 1; j >= 0; j--)
            {
                if (items[j] == numberToFind) 
                {
                    return j;
                }
            }
            return -1;
        }

        // TODO : Find index of last occurrence in given array. Solve using loop of your choice.
        public static int FirstIntegerIndex(int[] items, int numberToFind)
        {
            // TODO: Delete following line before implementing.
            for (int l = 0; l <= items.Length - 1; l++)
            {
                if (items[l] == numberToFind)
                {
                    return l;
                }
            }
            return -1;
        }
    }
}
