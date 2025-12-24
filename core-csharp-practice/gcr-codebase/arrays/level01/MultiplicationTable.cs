using System;
class MultiplicationTable{
    public static void Main(string[] args){

        //taking the input from the user for which we have to write the table
         Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        //initializing the array to store the multiplication table
        int[] table= new int[10];
        for(int i=1;i<=10;i++){
            table[i-1]= number*i;
            Console.WriteLine($"{number} * {i}= {table[i-1]}");
        }
    }
}