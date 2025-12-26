using System;
class ArgumentOutOfRange{
    public static void Main(string[] args){
        try{
            string s = "Hello";
            Console.WriteLine(s.Substring(5, 10));   //causes exception
        }
        catch (ArgumentOutOfRangeException){
            Console.WriteLine("ArgumentOutOfRangeException caught");
        }
    }
}
