using System;
class LongestWord{
    public static void Main(string[] args){

        //input from user
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        string longest = words[0];

       // Find the longest word
        for (int i = 1; i < words.Length; i++){
            if (words[i].Length > longest.Length)
                longest = words[i];
        }

        //output
        Console.WriteLine("Longest Word: " + longest);
    }
}
