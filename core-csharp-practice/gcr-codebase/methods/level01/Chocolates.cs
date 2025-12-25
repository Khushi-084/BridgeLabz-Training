using System;


class Chocolates{
    public static int[] chocolates(int val1, int val2){
        //calculating given and the remaining chocolates
        int given = val1 / val2; 
        int remainder = val1 % val2; /
        return new int[] { given, remainder };
    }
    public static void Main(string[] args){
        //taking inputs
        int numberOfChocolates = int.Parse(Console.ReadLine());
        int numberOfChildren = int.Parse(Console.ReadLine());


        //calling the method
        int[] arr = chocolates(numberOfChildren, numberOfChocolates);

        //output
        Console.WriteLine("The total number of chocolates given are " + arr[0] + "and the remaining are " + arr[1]);
    }
}