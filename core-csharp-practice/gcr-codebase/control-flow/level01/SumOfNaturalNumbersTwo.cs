 using System;
class SumOfNaturalNumbersTwo{

  static void Main(string [] args){

    //taking input from user
    Console.WriteLine("Enter a natural number");
    int n=Convert.ToInt32(Console.ReadLine());

    //check whether the number is natural number
    if(n>0){
      int sum=0;
      int i=1;

      //calculating sum using while loop
      while(i<=n){
        sum+=i;
        i++;
      }


      //calculating sum using formula
      int formulaSum=n*(n+1)/2;
      //comparing both sums
      if(sum==formulaSum){
        Console.WriteLine("The sum using while loop is: " + sum);
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