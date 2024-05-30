using System;

namespace CharToIntConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a character:");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // To move to the next line after the user input
            int asciiCode = (int)inputChar;
            Console.WriteLine($"The character you entered is '{inputChar}', its ASCII code is {asciiCode}");
        }
    }
}
