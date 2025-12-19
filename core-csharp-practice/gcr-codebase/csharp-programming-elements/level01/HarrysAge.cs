
using System;
class HarrysAge{

   public static void Main(string[] args){
    int birthyear = int.Parse(Console.ReadLine());
    int currentyear=2024;
    //formula to calculate current age 
    int age=currentyear-birthyear;

    //output
    Console.WriteLine("Harry's age in 2024 is " + age);
  }
}