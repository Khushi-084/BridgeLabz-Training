using System;
class SumOfNaturalNumbers{
    public static void Main(string[] args){
        //Taking input from user
        Console.WriteLine("Enter a positive integer:");
        int n=int.Parse(Console.ReadLine());
        
        //checking if the number is a natural number
        if(n<=0){
            Console.WriteLine("The number is not a natural number.");
            return;
        }

        //Calculating sum of natural numbers
        int sum=n*(n+1)/2;

        //output
        Console.WriteLine("The sum of first " + n + " natural numbers is: " + sum);
    }
}