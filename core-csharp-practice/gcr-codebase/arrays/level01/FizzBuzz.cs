using System;
class FizzBuzz{ 
    public static void Main(string[] args){

        //taking input from the user
        Consolle.Write("Enter a positive number: ");
        int number= int.Parse(Console.ReadLine());

        //checking the valid input
        if(number<=0){
            Console.WriteLine("Invalid input");
            return;
        }

        //initializing the array
        string[] result= new string[number+1];

        for(int i=1;i<=number;i++){
            if(i%3==0 && i%5==0){
                result[i]="FizzBuzz";
            }
            else if(i%3==0){
                result[i]="Fizz";
            }
            else if(i%5==0){
                result[i]="Buzz";
            }
            else{
                result[i]=i.ToString();
            }
        }


        //output
        for(int i=1;i<=number;i++){
            Console.WriteLine($"Position {i}={result[i]}");
        }
    }
}