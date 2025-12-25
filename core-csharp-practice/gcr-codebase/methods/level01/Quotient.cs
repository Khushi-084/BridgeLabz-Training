using System;

class Quotient{
    public static int[] QuotientRemainder(int number, int divisor){
        //calculating quotient and remainder
        int quotient = number / divisor; 
        int remainder = number % divisor;
        return new int[] { quotient, remainder };
    }

    public static void Main(string[] args){
        //taking inputs
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        //calling method by using array
        int[] arr = QuotientRemainder(num1, num2);

        //output
        Console.WriteLine(" The Quotient is " + arr[0] + " and Remainder " + arr[1]);
    }
}
