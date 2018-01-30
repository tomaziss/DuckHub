using System;

namespace ArrayOfArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            // https://en.wikipedia.org/wiki/Binomial_theorem
            Console.WriteLine("Enter the value, for how many lines in pascal triangle you want to show");
            var pascalTriangle = Convert.ToInt32(Console.ReadLine());

            int[][] array = new int[pascalTriangle][];

            for (int lineIndex = 0; lineIndex < array.Length; lineIndex++)
            {
                int arrayLength = lineIndex + 1;
                array[lineIndex] = new int[arrayLength];

                int[] line = array[lineIndex];

                // as first and last values are always 1, we set them manually
                line[0] = 1;
                line[line.Length - 1] = 1;

                // for all lines, which are not the 1st and not the second - we calculate new values from previous line
                if (lineIndex > 1)
                    for (int y = 1; y < line.Length - 1; y++)
                    {
                        var previousLine = array[lineIndex - 1];
                        line[y] = previousLine[y - 1] + previousLine[y];
                    }
            }

            Console.WriteLine("Here is our pascal triangle:");
            for (int arrayIndex = 0; arrayIndex < array.Length; arrayIndex++)
            {
                for (int y = 0; y < array[arrayIndex].Length; y++)
                {
                    Console.Write(array[arrayIndex][y] + " ");
                }
                Console.WriteLine(); ;
            }

            Console.ReadKey(true);
        }
    }
}
