using System;
class CountDigit{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a number: ");
        int number=int.Parse(Console.ReadLine());

        //iteration to count digits
        int count=0;
        while(number!=0){
            number /=10;
            count++;
        }

        //output
        Console.WriteLine("Number of digit= "+count);
    }
}