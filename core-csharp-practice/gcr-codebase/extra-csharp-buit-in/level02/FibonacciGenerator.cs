using System;
class FibonacciGenerator{
    public static void Main(string[] args){
        //taking input from user
        Console.Write("Enter number of terms: ");
        int n = int.Parse(Console.ReadLine());

        FibonacciSeries(n);
    }
    
    //method to print fibonacci
    static void FibonacciSeries(int num){
        int a = 0, b = 1;
        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= num; i++){
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
