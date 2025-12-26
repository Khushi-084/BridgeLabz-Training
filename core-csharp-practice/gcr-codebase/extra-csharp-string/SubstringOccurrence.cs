using System;
class SubstringOccurrence{
    public static void Main(string[] args){
        //input
        Console.WriteLine("Enter main string:");
        string str = Console.ReadLine();

        Console.WriteLine("Enter substring:");
        string sub = Console.ReadLine();

        int count = 0;
        //count
        for (int i = 0; i <= str.Length - sub.Length; i++)
        {
            if (str.Substring(i, sub.Length) == sub)
                count++;
        }

        //output
        Console.WriteLine("Occurrences: " + count);
    }
}
