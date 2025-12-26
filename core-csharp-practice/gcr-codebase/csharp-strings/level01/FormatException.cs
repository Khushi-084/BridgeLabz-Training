using System;
class FormatException{
    public static void Main(string[] args){
        try{
            int num = int.Parse("abc");   //Throws FormatException
        }
        catch (FormatException){
            Console.WriteLine("FormatException caught");
        }
    }
}
