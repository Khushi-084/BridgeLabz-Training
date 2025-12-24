using System;
class Multiplication6To9{
    public static void Main(string[] args){

        //taking the input from the user for which we have to write the multiplication from 6 to 9
        Console.Write("Enter a number: ");
        int number= int.Parse(Console.ReadLine());

        //initializing the array
        int[] result= new int[4];
        for(int i=6;i<=9;i++){
            result[i-6]= number*i;
            Console.WriteLine($"{number} * {i}= {result[i-6]}");   //output
        }
    }
}