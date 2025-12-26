using System;
class IndexOutOfRange{
    public static void Main(string[] args){
        try{
            string s = "Hello";
            Console.WriteLine(s[10]);  //causes exception
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("IndexOutOfRangeException caught");
        }
    }
}
