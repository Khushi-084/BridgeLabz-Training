using System;
class CountVowelsConsonants{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine().ToLower();

        int vowels = 0, consonants = 0;
        
        // Counting
        for (int i = 0; i < s.Length; i++){
            char ch = s[i];
            if (ch >= 'a' && ch <= 'z'){
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    vowels++;
                else
                    consonants++;
            }
        }
        

        //output
        Console.WriteLine("Vowels: " + vowels);
        Console.WriteLine("Consonants: " + consonants);
    }
}
