using System;

namespace CharToIntConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a character
            Console.WriteLine("Please enter a character:");

            // Read the input from the user
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); // To move to the next line after the user input

            // Cast the character to an int to get the ASCII code
            int asciiCode = (int)inputChar;

            // Output the result
            Console.WriteLine($"The character you entered is '{inputChar}', its ASCII code is {asciiCode}");
        }
    }
}
