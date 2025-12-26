using System;
class ReplaceWord{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        Console.WriteLine("Word to replace:");
        string oldWord = Console.ReadLine();

        Console.WriteLine("New word:");
        string newWord = Console.ReadLine();

        //replacing
        string result = sentence.Replace(oldWord, newWord);


        //output
        Console.WriteLine("Updated Sentence: " + result);
    }
}
