using System;
class SwapTwoNumbers{
    public static void Main(String[] args) {
        //taking input from user
        Console.Write("Enter number 1: ");
        int num1=int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2=int.Parse(Console.ReadLine());
        //swapping numbers
        int num3=num1;
        num1=num2;
        num2=num3;

        //output
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}