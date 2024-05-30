
using System;

namespace NumericTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a real number:");
            string input = Console.ReadLine();
           
            double number = double.Parse(input);

            int intNumber = (int)number;

            long longNumber = (long)number;

            Console.WriteLine($"The number you entered is {number}, as an int is {intNumber} and as a long is {longNumber}");
        }
    }
}
