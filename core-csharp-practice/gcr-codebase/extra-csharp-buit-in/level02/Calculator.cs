using System;
class Calculator{
    public static void Main(string[] args){
        //taking input from the user
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        //output
        double ans = Calculate(a, b, op);
        Console.WriteLine("Result: " + ans);
    }
    
    //method to calculate
    static double Calculate(double a, double b, char operation){
        switch (operation){
            case '+': return Add(a, b);
            case '-': return Subtract(a, b);
            case '*': return Multiply(a, b);
            case '/': return Divide(a, b);
            default: return 0;
        }
    }
    //methods calling according to the operation
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}
