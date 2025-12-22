using System;

class PositiveNumber{
    public static void Main(string[] args){
        //Taking input from user
        Console.WriteLine("Enter a number:");
        int number=int.Parse(Console.ReadLine());

        //Checking if the number is positive
        if(number>0){
            Console.WriteLine("Positive.");
        }
        else if(number==0){
            Console.WriteLine("Zero.");
        }
        else{
            Console.WriteLine("Negative.");
        }
    }
}