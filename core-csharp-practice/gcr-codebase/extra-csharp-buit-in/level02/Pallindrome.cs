using System;
class Pallindrome{
    public static void Main(string[] args){
        //taking input from user
        Console.Write("Enter a string: ");
        string s = Console.ReadLine();

        bool result = IsPallindrome(s);
        //output
        Console.WriteLine(result ? "Pallindrome" : "Not a Pallindrome");
    }
    
    //method to check if the string is a pallindrome
    static bool IsPallindrome(string str){
        string reversedString = "";
        for (int i = str.Length - 1; i >= 0; i--){
            reversedString += str[i];
        }
        return str.Equals(reversedString);
    }
}
