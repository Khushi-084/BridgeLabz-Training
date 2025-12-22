using System;
class RocketLaunchWhile
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine()); //input
        while (num >= 1) // while loop
        {
            Console.WriteLine(num);
            num--; //decrement
        }
    }

}