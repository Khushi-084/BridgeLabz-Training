
using System;
class KilometersToMiles
{

  public static void Main(string[] args){

    //taking input from user
    Console.WriteLine("Enter distance in kilometers:");
    double km=ConvertToDouble(Console.WriteLine());

    //formula to convert kilometers to miles 
    double miles=km/1.6;

    //output
    Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
  }
}