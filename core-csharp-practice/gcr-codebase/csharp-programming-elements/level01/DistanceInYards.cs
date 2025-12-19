using System;
public class DistanceInYards{
  public static void Main(String [] args){

    //taking the input from the user
    Console.WriteLine("Enter the distance in feet: ");
    double d = double.Parse(Console.ReadLine());
    //formulating the distance in yards and miles

    double dis_yards = d/3;
    double dis_miles = dis_yards/1760;

    //output
    Console.WriteLine("Your height in feet is " + d + " while in yards is " + dis_yards + " and in miles is " + dis_miles);
  }
}