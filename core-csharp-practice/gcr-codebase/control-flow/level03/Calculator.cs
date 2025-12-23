using System;
class Calculator{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter first number: ");
        double firstnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator (+,-,*,/): ");
        string operator=Console.Readline();

        //switch case to perform operations
        switch(operator){
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;
            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;
            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;
            case "/":
                Console.WriteLine("Result = " + (first / second));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        } 
    }
}