using System;
class RemoveDuplicates{
    public static void Main(string [] args){
        // taking input from user
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        string result = "";
        // removing duplicates
        for (int i = 0; i < str.Length; i++){
            if (!result.Contains(s[i]))
                result += str[i];
        }

        
        // output
        Console.WriteLine("After Removing Duplicates: " + result);
    }
}
