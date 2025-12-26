using System;

class Collinear{

    //method to calulate the area
     public static bool Area(double x1, double y1, double x2, double y2, double x3, double y3){
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }

    //method to calculate the slope
    public static bool Slope(double x1, double y1, double x2, double y2, double x3, double y3){
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    public static void Main(string[] args){
        //input from the user
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = Cdouble.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        //calling methods and printing the output
        Console.WriteLine("Collinear (Slope): " + Slope(x1, y1, x2, y2, x3, y3));
        Console.WriteLine("Collinear (Area): " + Area(x1, y1, x2, y2, x3, y3));
    }
}
