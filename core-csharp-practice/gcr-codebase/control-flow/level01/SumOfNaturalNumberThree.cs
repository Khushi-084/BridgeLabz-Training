using System;
class SumOfNaturalNumberThree{
  static void Main(string [] args){

    //taking input from user
    Console.WriteLine("Enter a natural number");
    int num=Convert.ToInt32(Console.ReadLine());

    //checking whether the number is natural number
    if(num>0){
      int sum=0;

      //calculating sum using for loop
      for(int i=1;i<=num;i++){
        sum+=i;
      }

      //calculating sum using formula
      int formulaSum=num*(num+1)/2;
      
      //comparing both sums
      if(sum==formulaSum){
        Console.WriteLine("The sum using for loop is: " + sum);
        Console.WriteLine("The sum using formula is: " + formulaSum);
        Console.WriteLine("Both are correct.");
      }else{
        Console.WriteLine("There is a change in computations.");
      }
    }else{
      Console.WriteLine("Please enter a valid natural number.");
    }
  }
}