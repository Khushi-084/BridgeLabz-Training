using System;
class VotingEligibility
{
    public static void Main(string[] args)
    {
        // Taking input from user
        Console.WriteLine("Enter age:");
        int age = int.Parse(Console.ReadLine());

        // Checking voting eligibility
        if (age >= 18){
            Console.WriteLine("The person's age is " + age + " and can vote.");
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " and cannot vote.");
        }
    }
}
