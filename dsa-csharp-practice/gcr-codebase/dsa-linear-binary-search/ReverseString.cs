using System;
using System.Text;

// Reverse a string using StringBuilder
class ReverseString{
    public static void Main(string[] args){
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

       // Use StringBuilder to reverse the string
        StringBuilder sb = new StringBuilder(input);
        for (int i = 0, j = sb.Length - 1; i < j; i++, j--){
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }

        Console.WriteLine("Reversed string: " + sb);
    }
}
