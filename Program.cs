using ConsoleApp3;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        // Read input from the user
        string input = Console.ReadLine();
        // Check if the input is not null before attempting to parse
        if (input != null)
        {
            // Attempt to parse the input to an integer
            try
            {
                // Parse the input string to an integer
                int NumberOfRolls = int.Parse(input);

                // Create an instance of Class1
                Class1 Rollingsimulator = new Class1();

                // Simulate dice rolling using the Rolling method of Class1
                int[] histArray = Rollingsimulator.Rolling(NumberOfRolls);

                // Create an instance of Histogram
                Histogram histogram = new Histogram();

                // Print the histogram based on the simulation results
                histogram.PrintHistogram(histArray, NumberOfRolls);
            }
            // Handle the case where parsing fails due to a FormatException
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        else
        {
            // Handle the case where input is null (error reading input)
            Console.WriteLine("Error reading input. Please try again.");
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!\r\n");
    }

}




/*
 Write a .NET console application using C# that simulates the rolling of two 6-sided dice. Use an
Array to keep track of the number of times that each combination is thrown. In other words,
keep track of how many times the combination of the two simulated dice is 2, how many times
the combination is 3, and so on, all the way up through 12.
Allow the user to choose how many times the “dice” will be thrown. Then, once you have the
number of rolls, pass that number to a second class that has a method that simulates the roll of
the dice for the number of times that the user specified. That method in the second class should
return the array containing the results. In the first class, use that array to print a histogram (using
the * character) that shows the total percentage each number was rolled. Each * will represent
1% of the total rolls.
 */