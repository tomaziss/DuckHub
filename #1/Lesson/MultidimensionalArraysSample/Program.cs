using System;

namespace MultidimensionalArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter grid X size");
            var xSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter grid Y size");
            var ySize = Convert.ToInt32(Console.ReadLine());

            // initialize array with values
            int[,] array = new int[xSize, ySize];

            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int x = 0; x < array.GetLength(0); x++)
                {
                    array[x, y] = (x + 1) * (y + 1);
                }
            }

            PrintArrayAsAGrid(array);

            Console.ReadKey();
        }

        static void PrintArrayAsAGrid(int[,] grid)
        {
            Console.WriteLine("Here is a grid");
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    Console.Write(grid[x, y] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
