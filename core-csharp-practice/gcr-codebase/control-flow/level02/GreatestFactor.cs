using System;
class GreatestFactor{
  static void Main(string[] args){

    //taking input from user
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    int greatestFactor=1;


    //iteration to find the greatest factor
    for(int i=number-1;i>=1;i--){
      if(number%i==0){
        greatestFactor=i;
        break;
      }
    }



    //output
    Console.WriteLine("Greatest Factor of " + number + " is: " + greatestFactor);
  }
}