using System;
class ToggleCase{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a string:");
        string s = Console.ReadLine();

        string result = "";
        //toggling
        for (int i = 0; i < s.Length; i++){
            char ch = s[i];
            if (char.IsUpper(ch))
                result += char.ToLower(ch);
            else
                result += char.ToUpper(ch);
        }

        //output
        Console.WriteLine("Toggled String: " + result);
    }
}
