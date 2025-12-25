using System;
class SumOfNaturalNumbers{
  public static void Main(string[] args){

    // Taking input from user
    Console.Write("Enter a natural number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    // Check if input is a natural number or not
      if (num <= 0){
        Console.WriteLine("Invalid input");
        return;
      }
      // Calculating the sum using recursion
      int sumRecursion = Recursion(num);

      // Calculate sum using the formula
      int sumForm = SumFormula(num);
      Console.WriteLine("Sum using recursion: " + sumRecursion);
      Console.WriteLine("Sum using formula: " + sumForm);
      // Comparing results
      if (sumRecursion == sumForm){
        Console.WriteLine("Both methods give the same result!");
      }else{
        Console.WriteLine("Something went wrong, results are different!");
      }
    }
   
    // Method to calculate sum using formula
    static int SumFormula(int num){
        return num * (num + 1) / 2;
    }

     // Method to calculate sum using recursion
    static int Recursion(int num){
      if (num == 1)
        return 1;
      else
        return num + Recursion(num - 1);
    }
}
