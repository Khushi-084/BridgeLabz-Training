using System;
using System.Text;

// Remove duplicate characters from a string using StringBuilder
class RemoveDuplicates{
    public static void Main(string[] args){
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        //   Create a boolean array to keep track of seen characters
        StringBuilder result = new StringBuilder();
        bool[] seen = new bool[256];

        foreach (char c in input){  // Iterate through each character in the input string
            if (!seen[c]){   // If character not seen before
                seen[c] = true;  // Mark character as seen
                result.Append(c);   // Append character to result
            }
        }

        Console.WriteLine("Without duplicates: " + result);
    }
}
