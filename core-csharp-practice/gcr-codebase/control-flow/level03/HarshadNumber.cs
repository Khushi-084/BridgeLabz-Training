using System;
class HarshadNumber{
    public static void Main(string[] args){
        //taking input from user
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        int temp = Math.Abs(number);
        int sum = 0;

        //calculating sum of digits
        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        //checking Harshad number
        if (sum != 0 && number % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }
}
