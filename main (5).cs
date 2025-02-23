/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
using System.Linq;
class Program
{
    // Function to count words in a sentence
    public static int CountWords(string sentence)
    {
        return sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    // Function to flip the first and last characters
    public static string FlipEndChars(string str)
    {
        if (str.Length < 2)
            return "Incompatible.";

        if (str[0] == str[str.Length - 1])
            return "Two's a pair.";

        char[] characters = str.ToCharArray();
        char temp = characters[0];
        characters[0] = characters[characters.Length - 1];
        characters[characters.Length - 1] = temp;

        return new string(characters);
    }

    // Function to check if characters are in order
    public static bool IsInOrder(string str)
    {
        for (int i = 0; i < str.Length - 1; i++)
        {
            if (str[i] > str[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    // Function to extract the first N vowels from a string
    public static string FirstNVowels(string str, int n)
    {
        string vowels = "aeiouAEIOU";
        string result = new string(str.Where(c => vowels.Contains(c)).Take(n).ToArray());
        return result.Length == n ? result : "invalid";
    }

    // Function to shift each letter to the next one in the alphabet
    public static string Move(string str)
    {
        return new string(str.Select(c => (char)(c + 1)).ToArray());
    }

    static void Main()
    {
        // Test cases for CountWords
        Console.WriteLine(CountWords("Just an example here move along")); // Output: 6
        Console.WriteLine(CountWords("This is a test")); // Output: 4

        // Test cases for FlipEndChars
        Console.WriteLine(FlipEndChars("Cat, dog, and mouse.")); // Output: ".at, dog, and mouseC"
        Console.WriteLine(FlipEndChars("ada")); // Output: "Two's a pair."
        Console.WriteLine(FlipEndChars("Ada")); // Output: "adA"

        // Test cases for IsInOrder
        Console.WriteLine(IsInOrder("abc")); // Output: true
        Console.WriteLine(IsInOrder("edabit")); // Output: false

        // Test cases for FirstNVowels
        Console.WriteLine(FirstNVowels("sharpening skills", 3)); // Output: "aei"
        Console.WriteLine(FirstNVowels("major league", 5)); // Output: "aoeau"
        Console.WriteLine(FirstNVowels("hostess", 5)); // Output: "invalid"

        // Test cases for Move
        Console.WriteLine(Move("hello")); // Output: "ifmmp"
        Console.WriteLine(Move("bye")); // Output: "czf"
        Console.WriteLine(Move("welcome")); // Output: "xfmdpnf"
    }
}    