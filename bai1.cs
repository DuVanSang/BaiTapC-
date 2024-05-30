using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user to input an integer
            Console.WriteLine("Please enter an integer:");

            // Read the input from the user
            string input = Console.ReadLine();

            // Convert the input string to an integer
            int number = int.Parse(input);

            // Cast the integer to a double
            double doubleNumber = (double)number;

            // Output the result
            Console.WriteLine($"The number you entered is {number} and as a double is {doubleNumber}");
        }
    }
}
