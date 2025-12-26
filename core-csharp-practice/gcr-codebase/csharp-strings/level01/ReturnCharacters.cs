using System;
class ReturnCharacters{
    public static void Main(string[] args){
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        char[] characters = returnCharacters(s);
        Console.WriteLine("Characters:");
        foreach (char c in characters){
            Console.Write(c + " ");
        }
    }

    // Function to return an array of characters
    static char[] returnharacters(string str){
        char[] chars = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            chars[i] = str[i];
        }
        return chars;
    }
}
