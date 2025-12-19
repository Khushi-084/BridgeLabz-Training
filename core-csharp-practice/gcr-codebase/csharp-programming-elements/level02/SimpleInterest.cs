using System;
class SimpleInterest
{
    static void Main()
    {

        //taking input from user
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter time: ");
        double time = double.Parse(Console.ReadLine());
        //formulating simple interest
        double si = (principal * rate * time) / 100;


        //output
        Console.WriteLine("The Simple Interest is "+si "for Principal "+principal+", Rate of Interest "+rate "and Time "+time);
    }
}
