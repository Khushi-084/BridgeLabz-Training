using System;
class ArmstrongNumber{
    public static void Main(string[] args){
        //taking input from user
        Console.WriteLine("Enter a number:"); 
        int num = int.Parse(Console.ReadLine());
        int originalNumber = num;
        int sum = 0;

        //iteration to check Armstrong number
        while (originalNumber != 0){
            int digit = originalNumber % 10;      // Extract last digit
            sum += digit * digit * digit;         // Add cube of digit
            originalNumber /= 10;                  // Remove last digit
        }

        //output
        if (sum == num)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
