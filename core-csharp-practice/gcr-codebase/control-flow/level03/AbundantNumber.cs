using System;
class AbundantNumber
{
    public static void Main(string[] args)
    {

        //taking input from user
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        // Check if the number is positive
        if (num <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            return;
        }

        int sum = 0;

        // Find sum of proper divisors
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        // Check abundant number
        if (sum > num)
        {
            Console.WriteLine($"{num} is an Abundant Number");
        }
        else
        {
            Console.WriteLine($"{num} is NOT an Abundant Number");
        }
    }
}
