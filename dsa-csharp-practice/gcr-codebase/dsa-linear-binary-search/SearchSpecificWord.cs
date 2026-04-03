using System;

// Program to search for a specific word in given sentences
class SearchSpecificWord{
    public static void Main(string[] args){
        // Get number of sentences from user
        Console.Write("Enter number of sentences: ");
        int n = int.Parse(Console.ReadLine());

        string[] sentences = new string[n];   // Declare array to hold sentences

        // Get sentences from user
        Console.WriteLine("Enter sentences:");
        for (int i = 0; i < n; i++)
            sentences[i] = Console.ReadLine();
        
        // Get word to search from user
        Console.Write("Enter word to search: ");
        string word = Console.ReadLine();

        int index = -1;       // Initialize index for found word

        for (int i = 0; i < n; i++){
            if (sentences[i].Contains(word)){      // Check if sentence contains the word
                index = i;                         //  Store index
                break;
            }
        }


        if (index != -1)
            Console.WriteLine("Word found in sentence index: " + index);
        else
            Console.WriteLine("Word not found");
    }
}
