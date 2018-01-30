using System;

namespace CalculatorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            char operation;
            do
            {
                Console.Write("Please enter first number: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter second number: ");
                double b = Convert.ToDouble(Console.ReadLine());

                operation = Console.ReadLine()[0];
                // could be replaced by, which then reads single pressed key instead of reads whole line and then takes 1st symbol of the line
                // operation = Console.ReadKey(true).KeyChar;

                if (operation == '+')
                    WriteResult(a + b);
                else if (operation == '-')
                    WriteResult(a - b);
                else if (operation == '*')
                    WriteResult(a * b);
                else if (operation == '/')
                    WriteResult(a / b);
                else
                    Console.WriteLine("Do not understand what you want");
                
                // alternatively in this case we can use switch statement
                //switch (operation)
                //{
                //    case '+':
                //        WriteResult(a + b);
                //        break;
                //    case '-':
                //        WriteResult(a - b);
                //        break;
                //    case '*':
                //        WriteResult(a * b);
                //        break;
                //    case '/':
                //        WriteResult(a / b);
                //        break;
                //    default:
                //        Console.WriteLine("Do not understand what you want");
                //        break;
                //}
            } while (operation == '+' || operation == '-' || operation == '*' || operation == '/');

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void WriteResult(double result)
        {
            Console.WriteLine("Result is: " + result);
        }
    }
}
