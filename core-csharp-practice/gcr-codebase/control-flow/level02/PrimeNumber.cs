using System;
class PrimeNumber{
  static void Main(string [] args){

    //taking input from user
    Console.WriteLine("Enter a number");
    int number=Convert.ToInt32(Console.ReadLine());
    bool isPrime=true;

     //iteration for checking its divisibility
    if(number<=1){
      isPrime=false;
    }
    else{
      for(int i=2;i<=Math.Sqrt(number);i++){
        if(number%i==0){
          isPrime=false;
          break;
        }
      }
    }

    //output
    if(isPrime){
      Console.WriteLine(number + "is a Prime Number");
    }else{
      Console.WriteLine(number + "is not a Prime Number");
    }
  }
}

