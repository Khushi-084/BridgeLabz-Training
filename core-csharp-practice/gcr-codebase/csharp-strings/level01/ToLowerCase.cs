using System;
class ToLowerCase{

    public static void Main(string[] args){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        string manualLower = ToLower(str);

        Console.WriteLine("Lowercase: " + manualLower);
        Console.WriteLine("Built-in Lowercase: " + str.ToLower());

        bool isSame = CompareStrings(str.ToLower(), manualLower);
        Console.WriteLine("Comparison: " + isSame);
    }


    // Function to convert a string to lowercase
    static string ToLower(string str){
        string result = "";
        foreach (char c in str)
        {
            if (c >= 'A' && c <= 'Z')
                result += (char)(c + 32);   // ASCII conversion
            else
                result += c;
        }
        return result;
    }
    

    // Function to compare two strings
    static bool CompareStrings(string str1, string str2){
        return str1.Equals(str2);
    }
}
