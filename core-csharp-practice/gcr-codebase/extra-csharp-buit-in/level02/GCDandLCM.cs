using System;
class GCDandLCM{
    public static void Main(string[] args){
        //taking input from user
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int gcd = CalculateGCD(a, b);
        int lcm = CalculateLCM(a, b, gcd);
        

        //output
        Console.WriteLine("GCD: " + gcd);
        Console.WriteLine("LCM: " + lcm);
    }

    //method to calculate GCD
    static int CalculateGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    //method to calculate LCM
    static int CalculateLCM(int a, int b, int gcd){
        return (a * b) / gcd;
    }
}
