using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Histogram
    {
        // Method to print a histogram based on an array of dice roll results
        public void PrintHistogram(int[] array, int rolls)
        {
            // Display a title for the histogram
            Console.WriteLine("Histogram:");
            Console.WriteLine($"DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = {rolls}.\r\n");

            // Iterate through the array representing dice roll results
            for (int i = 0; i < array.Length; i++)
            {
                // Display the sum of dice (i + 2 represents the possible sums)
                Console.Write($"{i + 2}: ");

                // Calculate the number of '*' characters to represent the percentage of each roll
                // using Math.Round to handle rounding and ensure correct display
                for (int j = 0; j < Math.Round(array[i] / (rolls / 100.0f)); j++)
                {
                    // Display '*' characters to represent the percentage
                    Console.Write("*");
                }

                // Move to the next line for the next dice roll result
                Console.WriteLine();
            }
        }
    }
}
