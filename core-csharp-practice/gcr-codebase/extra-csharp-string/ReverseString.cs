using System;
class ReverseString{
    public static void Main(string[] args){

        //input
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();
        string reverse = "";

        //reversing
        for (int i = s.Length - 1; i >= 0; i--){
            reverse += s[i];
        }
        
        //output
        Console.WriteLine("Reversed String: " + reverse);
    }
}
