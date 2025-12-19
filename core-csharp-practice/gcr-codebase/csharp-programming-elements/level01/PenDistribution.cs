
using System;
class PenDistribution{
  public static void Main(string[] args){
    int totalpens=14;
    int students=3;

    //formula to calculate pens per student
    int pensperstudents=totalpens/students;
    //formula to calculate remaining pens
    int remainingpens=totalpens%students;

    //output
    Console.WriteLine("The Pen Per Student is " + pensperstudents + " and the remaining pent not distributed is " +remainingpens);
  }
}