using System;
using System.Text;

// Concatenate an array of strings using StringBuilder
class ConcatenateStrings{
    public static void Main(string[] args){
        string[] arr = { "Hello", " ", "World", "!" };

        StringBuilder sb = new StringBuilder(); // Using StringBuilder for efficient concatenation
        foreach (string s in arr){    // Iterate through each string in the array
            sb.Append(s);     // Append the string to StringBuilder
        } 

        Console.WriteLine(sb.ToString());
    }
}
