using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5_negatives
{
    class Program
    {
        static void Main(string[] args)
        {
            // program sums even and odd N numbers.

            int n = 0;
            int evensum = 0;
            int oddsum = 1;
            string message = string.Empty;
            Console.Write("Please type amount of numbers for calculating odd and even sums: ");

            bool userinput = int.TryParse(Console.ReadLine(), out n);
            if (!userinput) // incorrect input
            {
                message = "Input is NOT a number.";
            }

            else if (n < 0)  // negative numbers calculations
            {
                oddsum = -1;
                Console.Write("Calculating even and odd number sum: ");
                for (int i = 0; i > n -1; i--)
                {
                    Console.Write(" {0}", i); // error check line
                    evensum = evensum + i;
                    oddsum = oddsum + i + 1;
                    i--;
                }
                message = string.Format("You gave {0} numbers to sum. \nThe evensum is {1} and oddsum is {2}", n, evensum, oddsum);
            }

            else // do calculation
            {
                Console.Write("Calculating even and odd number sum: ");
                for (int i = 0; i < n + 1; i++)
                {
                    Console.Write(" {0}", i); // error check line
                    evensum = evensum + i;
                    oddsum = oddsum + i - 1;
                    i++;
                }


                message = string.Format("You gave {0} numbers to sum. \nThe evensum is {1} and oddsum is {2}", n, evensum, oddsum);
            }

            Console.WriteLine("\n" + message);
            Console.ReadKey();
        }
    }
}
