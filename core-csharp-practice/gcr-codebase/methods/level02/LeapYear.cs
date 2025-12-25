using System;
class LeapYear{
  public static void Main(string[] args){
    
    //taking input
    Console.Write("Enter a year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    // Check if the year is valid or not
    if (year < 1582){
      Console.WriteLine("Enter other year");
      return;
    }
    bool isLeap = IsLeapYear(year);
    if (isLeap){
      Console.WriteLine(year + " is a Leap Year.");
    }else{
      Console.WriteLine(year + " is not a Leap Year");
    }
  }
  
  // Method to check if a year is a leap year
    static bool IsLeapYear(int y){
    if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0)){
      return true;
    }else{
      return false;
    }
  }
}
