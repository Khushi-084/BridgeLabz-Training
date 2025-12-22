using System;
class SmallestNumber{
    
    public static void Main(string[] args){
        //Taking input from user
        Console.WriteLine("Enter first number:");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int num3=int.Parse(Console.ReadLine());
        

        //comaring numbers
        if(num1<=num2 && num1<=num3){
            Console.WriteLine("The smallest number is: " + num1);
        }
        else if(num2<=num1 && num2<=num3){
            Console.WriteLine("The smallest number is: " + num2);
        }
        else{
            Console.WriteLine("The smallest number is: " + num3);
        }
    }
}