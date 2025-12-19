
using System;
class DistanceFromKilometersToMiles
{
  public static void Main(string[] args){
    double kilometers=10.8;
    //formula to convert kilometers to miles
    double miles=kilometers/1.6;

    //output
    Console.WriteLine("The Distance " + kilometers + " km in miles is " + miles);
  }
}