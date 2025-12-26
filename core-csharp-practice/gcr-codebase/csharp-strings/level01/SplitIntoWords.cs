using System;
class SplitIntoWords{
    public static void Main(string[] args){
        Console.WriteLine("Enter a sentence:");
        string str = Console.ReadLine();

        DisplayWordsAndLengths(str);
    }
    

    // Function to display words and their lengths
    static void DisplayWordsAndLengths(string str){
        string word = "";
        Console.WriteLine("Word\tLength");
        for (int i = 0; i < str.Length; i++){
            if (str[i] != ' '){
                word += str[i];
            }
            else{
                LastWord(word);
                word = "";
            }
        }
        LastWord(word);  // last word
    }


    // Function to display the last word
    static void LasttWord(string word){
        int length = 0;
        foreach (char c in word)
            length++;

        Console.WriteLine(word + "\t" + length);
    }
}
