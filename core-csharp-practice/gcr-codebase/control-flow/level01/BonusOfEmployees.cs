using System;
class BonusOfEmployees{
  static void Main(string [] args){

    //taking salary and years of service as input
    Console.WriteLine("Enter your salary");
    double salary=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your years of service");
    int yearsOfService=Convert.ToInt32(Console.ReadLine());


    //checking whether the years of service is more than 5
    if(yearsOfService>5){
      double bonus=salary*0.05;
      Console.WriteLine("Your bonus amount is: " + bonus);
    }else{
      Console.WriteLine("You are not eligible for bonus");
    }
  }
}