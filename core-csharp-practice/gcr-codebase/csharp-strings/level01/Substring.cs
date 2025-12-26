using System;
class Substring{
    public static void Main(string[] args){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter start index:");
        int start = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter end index:");
        int end = int.Parse(Console.ReadLine());

        string result = CreateSubstring(str, start, end);
        Console.WriteLine("Manual Substring: " + result);
        Console.WriteLine("Built-in Substring: " + str.Substring(start, end - start));
    }
     

     // Function to create substring
    static string CreateSubstring(string s, int start, int end) {
        string sub = "";
        for (int i = start; i < end; i++)
        {
            sub += s[i];
        }
        return sub;
    }
}
