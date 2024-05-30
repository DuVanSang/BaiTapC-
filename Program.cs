using System;

namespace FindMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter the number of elements in the array
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            // Declare an array to hold the integers
            int[] numbers = new int[n];

            // Ask the user to enter the elements of the array
            Console.WriteLine($"Enter {n} integers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the maximum value in the array
            int max = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            // Output the maximum value
            Console.WriteLine($"The maximum value in the array is {max}");
        }
    }
}
