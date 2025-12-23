using System;
class Calculator
{
    public static void Main(string[] args) {
        //taking input from user
        Console.WriteLine("Enter first number:");
        double firstnum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double secondnum = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operator (+, -, *, /):");
        string operator = Console.ReadLine();

        //performing calculation based on operator
        switch (operator)
        {
            case "+":
                Console.WriteLine("Result = " + (firstnum + secondnum));
                break;

            case "-":
                Console.WriteLine("Result = " + (firstnum - secondnum));
                break;

            case "*":
                Console.WriteLine("Result = " + (firstnum * secondnum));
                break;

            case "/":
                if (secondnum != 0)
                    Console.WriteLine("Result = " + (firstnum / secondnum));
                else
                    Console.WriteLine("Division by zero is not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
