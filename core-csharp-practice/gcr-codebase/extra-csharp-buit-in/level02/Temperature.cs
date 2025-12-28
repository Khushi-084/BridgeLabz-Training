using System;
class Temperature{
    public static void Main(string[] args){
        //taking inputs from the user
        Console.Write("Enter temperature: ");
        double t = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = char.ToUpper(Console.ReadLine()[0]);
        
        //output
        if (choice == 'C')
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(t));
        else if (choice == 'F')
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(t));
    }
    //method for conversion 
    static double FahrenheitToCelsius(double f){
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c){
        return (c * 9 / 5) + 32;
    }
}
