using System;
class RemoveSpecificChar{
    public static void Main(string[] args) {

        // taking input from user
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter character to remove:");
        char ch = Console.ReadLine()[0];

        string result = "";
        
        // removing
        for (int i = 0; i < str.Length; i++){
            if (str[i] != ch)
                result += str[i];
        }

        // output
        Console.WriteLine("Modified String: " + result);
    }
}
