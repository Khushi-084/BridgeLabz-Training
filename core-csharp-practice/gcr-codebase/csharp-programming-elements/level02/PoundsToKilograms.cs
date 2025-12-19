using System;
class PoundsToKilograms
{
    publicstatic void Main(string[] args)
    {
        //taking input from user
        Console.Write("Enter weight in pounds: ");
        double pounds = double.Parse(Console.ReadLine());

        //formulating kilograms
        double kg = pounds / 2.2;

        //output
        Console.WriteLine("The weight of the person in pounds is "+pounds+ "and in kg is "+ kg);
    }
}
