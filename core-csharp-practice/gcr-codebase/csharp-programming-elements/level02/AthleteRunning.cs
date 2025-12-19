using System;
class AthleteRunning
{
    public static void Main(string[] args)
    {
        //taking input from user
        Console.Write("Enter side1: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter side2: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter side3: ");
        double side3 = double.Parse(Console.ReadLine());

        //formulating the perimeter and number of rounds
        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;

        //output
        Console.WriteLine("The total number of rounds the athlete will run is "+ rounds);
    }
}
