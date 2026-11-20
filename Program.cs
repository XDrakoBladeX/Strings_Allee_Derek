
using System;

namespace Strings_Allee_Derek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a single character
            Console.Write("Enter a single character: ");
            char myChar = Console.ReadKey().KeyChar;

            // Check whether the character is a letter
            bool isLetter = char.IsLetter(myChar);

            // Display the character and the result
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            // Ask the user to enter a sentence
            Console.Write("\nEnter a string of words: ");
            string sentence = Console.ReadLine();

            // Ask the user for a word to search for
            Console.Write("Enter a word to search for: ");
            string searchWord = Console.ReadLine();

            // Check whether the sentence contains the word
            bool containsWord = sentence.Contains(searchWord);

            // Display the word search result
            Console.WriteLine($"{searchWord} exists in \"{sentence}\": {containsWord}");
        }
    }
}
