using System;
class Anagram{
    public static void Main(string[] args){

        //taking input from the user
        Console.WriteLine("Enter first string:");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string s2 = Console.ReadLine();

        //comparing
        if (s1.Length != s2.Length){
            Console.WriteLine("Not Anagrams");
            return;
        }

        char[] a1 = s1.ToCharArray();
        char[] a2 = s2.ToCharArray();

        //sorting
        Array.Sort(a1);
        Array.Sort(a2);

        //output
        if (new string(a1) == new string(a2))
            Console.WriteLine("Anagrams");
        else
            Console.WriteLine("Not Anagrams");
    }
}
