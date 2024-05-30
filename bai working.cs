using System;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a string and store it in userInput
            Console.WriteLine("Enter a string:");
            string userInput = Console.ReadLine();

            // Call the ReverseString method and print the reversed string
            string reversedString = ReverseString(userInput);
            Console.WriteLine($"Reversed string: {reversedString}");

            // Prompt the user to enter a search string and store it in searchString
            Console.WriteLine("Enter a search string:");
            string searchString = Console.ReadLine();

            // Call the CountOccurrences method and print the number of occurrences
            int occurrences = CountOccurrences(userInput, searchString);
            Console.WriteLine($"Number of occurrences of '{searchString}': {occurrences}");

            // Prompt the user to enter an old substring and a new substring
            Console.WriteLine("Enter the old substring to replace:");
            string oldSubstring = Console.ReadLine();
            Console.WriteLine("Enter the new substring to replace with:");
            string newSubstring = Console.ReadLine();

            // Call the ReplaceSubstring method and print the modified string
            string replacedString = ReplaceSubstring(userInput, oldSubstring, newSubstring);
            Console.WriteLine($"Modified string: {replacedString}");

            // Call the RemoveWhitespace method and print the string without whitespace
            string stringWithoutWhitespace = RemoveWhitespace(userInput);
            Console.WriteLine($"String without whitespace: {stringWithoutWhitespace}");
        }

        // Method to reverse a string
        static string ReverseString(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to count occurrences of a substring in a string
        static int CountOccurrences(string inputString, string searchString)
        {
            int count = 0;
            int startIndex = 0;
            while ((startIndex = inputString.IndexOf(searchString, startIndex)) != -1)
            {
                count++;
                startIndex += searchString.Length;
            }
            return count;
        }

        // Method to replace all occurrences of a substring with a new substring
        static string ReplaceSubstring(string inputString, string oldSubstring, string newSubstring)
        {
            return inputString.Replace(oldSubstring, newSubstring);
        }

        // Method to remove all whitespace characters from a string
        static string RemoveWhitespace(string inputString)
        {
            return string.Concat(inputString.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}
