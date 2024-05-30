using System;

namespace FindMaxInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            Console.WriteLine($"Enter {n} integers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"The maximum value in the array is {max}");
        }
    }
}
