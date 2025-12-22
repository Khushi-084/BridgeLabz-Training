using System;
class OddOrEven{
  static void Main(string [] args){

    //taking input from user
    Console.WriteLine("Enter a natural number");
    int number=Convert.ToInt32(Console.ReadLine());
    
    //checking whether the number is natural number
    if(number<1){
      Console.WriteLine("Wrong input");
    }else{
      for(int i=1;i<=number;i++){
        //checking whether the number is odd or even
        if(i%2==0){
          Console.WriteLine(i + " is an even number");
        }else{
          Console.WriteLine(i + " is an odd number");
        }
      }
    }
  }
}