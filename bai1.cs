using System;

namespace DataTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            double doubleNumber = (double)number;
            Console.WriteLine($"The number you entered is {number} and as a double is {doubleNumber}");
        }
    }
}
