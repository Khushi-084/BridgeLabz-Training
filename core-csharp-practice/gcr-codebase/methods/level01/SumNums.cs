using System;
class SumNum{
    public static int sum(int num){
        int sum = 0;
        //calculating sum of n natural numbers
        for (int i = 0; i < num; i++){
            sum += i;
        }
        return sum;
    }
    public static void Main(string[] args){
        //taking input
        int num = int.Parse(Console.ReadLine());
        //calling the method
        int result = sum(num); 
        //output
        Console.WriteLine("The Sum of n Natural nums is" + result);
    }
}