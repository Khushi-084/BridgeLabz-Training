using System;
class SumUntilZeroUsingWhile{
  static void Main(string [] args){

    //initializing total sum variable
    double total=0.0;
    double number;

    //taking input from user
    Console.WriteLine("Enter a number");
    number=Convert.ToDouble(Console.ReadLine());

    //calculating sum until user enter 0 or negative number
    while(true){
      if(number<=0){
        break;
      }
      total+=number;
      Console.WriteLine("Enter a number");
      number=Convert.ToDouble(Console.ReadLine());
    }

    //output
    Console.WriteLine("The total sum is:" + total);
  }
}