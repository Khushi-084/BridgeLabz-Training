using System;
public class Calculator
{
    
    public static void Main(string[] args)
    {
        //Inputs
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        //Calculations
        double addition = num1 + num2;
        double subtraction = num1 - num2;
        double multiplication = num1 * num2;
        double division = num1 / num2;

        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + num1 + " and " + num2 + " is " + addition + ", " + subtraction + ", " + multiplication + ", and " + division);
    }
}
