using System;
class HarshadNumber{
    public static void Main(String[] args){

        //taking input from user
        Console.WriteLine("Enter a number: ");
        int number=int.Parse(Console.ReadLine());
        int temp=number;
        int sum=0;

        //iteration to find sum of digits
        while(temp!=0){
            sum+=temp%10;
            temp/=10;
        }

        //output
        if(number%sum==0){
            Console.WriteLine("Harshad Number");
        }
        else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}