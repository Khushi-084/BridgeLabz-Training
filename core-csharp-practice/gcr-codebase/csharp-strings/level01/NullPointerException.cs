using System;
class NullPointerException{
    public static void Main(string[] args){
        try{
            string text = null;
            Console.WriteLine(text.Length);  // NullReferenceException
        }
        catch (NullReferenceException ){
            Console.WriteLine("NullReferenceException caught");
        }
    }
}
