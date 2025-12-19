using System;
class DivideChocolate
{
    public static void Main(String[] args)
    {
        //taking input from user
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        //formulating the number of chocolates each child gets and remaining chocolates
        int eachChildGets = numberOfChocolates / numberOfChildren;
        int remaining = numberOfChocolates % numberOfChildren;

        //output
        Console.WriteLine("The number of chocolates each child gets is "+eachChildGets +"and the number of remaining chocolates is "+remaining);
    }
}
