using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class1
    {
        /*
         method that simulates the roll of
            the dice for the number of times that the user specified. That method in the second class should
            return the array containing the results.
         */
        public int[] Rolling(int NumberOfRolls)
        {
            // Declare an array to store the counts of each possible sum of two dice
            int[] results;

            // Initialize the array with length 11 to represent sums 2 to 12 (indices 0 to 10)
            results = new int[11];

            // Create an instance of the Random class for generating random numbers
            Random random = new Random();

            // Loop through the specified number of dice rolls
            for (int i = 0; i < NumberOfRolls; i++)
            {
                // Generate random numbers for the rolls of two six-sided dice
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);

                // Calculate the sum of the two dice rolls
                int sum = dice1 + dice2;

                // Increment the count in the results array corresponding to the sum
                results[sum - 2]++;
                /* To index the results array correctly, sum - 2 is used.
                   If the sum is 2, it will increment results[0];
                   If the sum is 3, it will increment results[1], and so on.
                   This ensures that the results array represents the counts of each possible sum. */
            }

            // Return the array containing the counts of each possible sum
            return results;
        }
    }
}