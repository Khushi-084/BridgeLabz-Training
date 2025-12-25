using System;
using System.IO.Compression;

class Trigonometry{
    public double[] TrigonometricFunction(double angle){

        //converting degree to radian
        double val = angle * 3.14 / 100; 
        //using the inbuilt Math
        double sin = Math.Sin(val);
        double cos = Math.Cos(val);
        double tan = Math.Tan(val);
        return new double[] { sin, cos, tan };
    }
    public static void Main(string[] args){
        //taking Input
        double angle = double.Parse(Console.ReadLine());
        //calling method
        int[] arr = TrigonometricFunction(angle);

        //output
        Console.WriteLine("The sin is " + arr[0] + "the cos is " + arr[1] + "the tan value is " + arr[2]);
    }
}