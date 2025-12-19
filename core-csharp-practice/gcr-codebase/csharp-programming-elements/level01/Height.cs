using System;

public class Height
{
    public static void Main(string[] args)
    {
        //taking input from user
        double height = double.Parse(Console.ReadLine());

        //formulating the height in feet and inches
        double total = height / 2.54;
        int feet = (int)(total / 12);
        double inches = total % 12;

        //output
        Console.WriteLine( "Your Height in cm is " + height + " while in feet is " + feet + " and inches is " + inches);
    }
}
