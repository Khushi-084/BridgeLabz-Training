using System;
public class UniversityDiscount
{
    public static void Main(String[] args)
    {
        //taking input from user
        Console.WriteLine("Enter the total fees amount: ");
        double fees = double.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine());
        //formulating the discount amount and final fees after discount
        double discounted = (fees * discount) / 100;
        double final = fees - discounted;

        //output
        Console.WriteLine("The discount amount in INR is " + discounted + " and final discounted fees is " + final);
    }
}