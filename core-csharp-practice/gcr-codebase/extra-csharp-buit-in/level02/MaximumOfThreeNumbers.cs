using System;
class MaximumOfThreeNumbers{
    public static void Main(string[] args){
        //taking input from the user
        int a = ReadNumber();
        int b = ReadNumber();
        int c = ReadNumber();

        int max = FindMaximum(a, b, c);
        Console.WriteLine("Maximum number is: " + max);
    }
    
    //method to read the number
    static int ReadNumber(){
        Console.Write("Enter a number: ");
        return int.Parse(Console.ReadLine());
    }
    
    //method to find the maximum number
    static int FindMaximum(int a, int b, int c){
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
}
