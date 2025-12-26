using System;
class ArrayIndexOutOfRange{
    public static void Main(string[] args){
        try{
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[5]);   //causes exception
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("IndexOutOfRangeException caught");
        }
    }
}
