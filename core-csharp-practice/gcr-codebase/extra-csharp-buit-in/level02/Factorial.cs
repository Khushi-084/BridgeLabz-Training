using System;
class Factorial{
    public static void Main(string[] args){
        //taking input from user
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int ans = Factorial(n);
        //output
        Console.WriteLine("Factorial: " + ans);
    }
    
    //method to calculate factorial
    static int Factorial(int num){
        if (num == 0)
            return 1;
        return num * Factorial(num - 1);
    }
}
