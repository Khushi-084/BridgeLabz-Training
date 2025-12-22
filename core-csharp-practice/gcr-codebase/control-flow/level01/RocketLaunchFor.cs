using System;
class RocketLaunchFor
{
    public static void Main(string[] args)
    {
        //Taking input from user
        int num = int.Parse(Console.ReadLine()); 
        //countdown using for loop
        for (int i = num; i >= 1; i--) 
        {
            //output
            Console.WriteLine(i);
        }
    }

}