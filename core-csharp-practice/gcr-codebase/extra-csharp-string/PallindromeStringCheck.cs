using System;
class PalindromeStringCheck{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        
        //reversing
        string reverse = "";
        for (int i = s.Length - 1; i >= 0; i--)
            reverse += s[i];

        //output
        if (s == reverse){
            Console.WriteLine("Palindrome");
        }else{
            Console.WriteLine("Not Palindrome");
        }
    }
}
