using System;

class Factors{
  public static void Main(string[] args){

     //taking input from user
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Factors of " + number + " are:");


    //iteration to find factors
    for(int i=1;i<=number;i++){
      if(number%i==0){
        Console.WriteLine(i);
      }
    }
  }
}