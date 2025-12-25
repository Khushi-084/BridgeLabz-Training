using System;
class PositiveNegative{
    //method to check positive negative or zero
    public static int fun(int num) {
        if(num < 0){
            return -1;
        }
        if (num > 0){
            return 1;
        }
        return 0;
    }
    public static void Main(string[] args){
        //taking input
        Console.Write("The number is : ");
        int n = int.Parse(Console.ReadLine());

        //calling the method
        int result = fun(n);
        //output
        Console.WriteLine("The result of the outcome is : " + result);
    }
}