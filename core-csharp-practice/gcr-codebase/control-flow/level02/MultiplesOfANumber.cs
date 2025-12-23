using System;
class MultiplesOfANumber{
  static void Main(string[] args){

    //taking input from user
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Multiples of " + number + " below 100 are:");

    
    //iteration to find multiples
    for(int i=100;i>=1;i--){
      if(i%number==0){
        Console.WriteLine(i);
      }
    }
  }
}