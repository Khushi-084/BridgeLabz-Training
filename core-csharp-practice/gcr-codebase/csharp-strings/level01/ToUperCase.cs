using System;
class ToUpperCase{
    public static void Main(string[] args){
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();

        string manualUpper = ToUpper(s);

        Console.WriteLine("Uppercase: " + manualUpper);
        Console.WriteLine("Built-in Uppercase: " + s.ToUpper());

        bool compare = CompareStrings(s.ToUpper(), manualUpper);
        Console.WriteLine("Comparison: " + compare);
    }


    // Function to convert a string to uppercase
    static string ToUpper(string s){
        string result = "";
        foreach (char c in s)
        {
            if (c >= 'a' && c <= 'z')
                result += (char)(c - 32);
            else
                result += c;
        }
        return result;
    }
    

    // Function to compare two strings
    static bool CompareStrings(string s1, string s2){
        return s1.Equals(s2);
    }
}
