using System;
class CountDown{
    public static void Main(string[] args){

        //Taking input from user
        Console.WriteLine("Enter a number:");
        int n=int.Parse(Console.ReadLine());


        //countdown using while loop
        while(n>=1){
            //output
            Console.WriteLine(n);
            n--;
        }
    }
}