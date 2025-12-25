using System;
class FactorsOfNumber{
  public static void Main(string[] args){

    //taking input
    Console.Write("Enter a number: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // Finding factors of the number
    int[] factors = FindFactors(n);
    Console.Write("Factors: ");
    foreach (int factor in factors){
      Console.Write(factor + " ");
    }
    Console.WriteLine();

    // Calculate the sum, product, sum of squares of the factors
    int sum = SumOfFactors(factors);
    int product = ProductOfFactors(factors);
    double sumOfSquares = SumOfSquares(factors);


    // output
    Console.WriteLine("Sum of factors: " + sum);
    Console.WriteLine("Product of factors: " + product);
    Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
  }

  // Method to find factors and store them in an array
  public static int[] FindFactors(int n){
  int count = 0;
  // Counting the number of factors
  for (int i = 1; i <= n; i++){
    if (n % i == 0)
      count++;
  }

  // Initialize array with factor count
  int[] factors = new int[count];
  int index = 0;
  // Storing the factors
  for (int i = 1; i <= n; i++){
    if (n % i == 0){
      factors[index] = i;
      index++;
    }
  }
  return factors;
  }


// Method to find product of factors
    public static int ProductOfFactors(int[] factors){
        int product = 1;
        foreach (int factor in factors){
            product *= factor;
        }
        return product;
    }

 // Method to find sum of squares of factors
    public static double SumOfSquares(int[] factors){
        double sumSquares = 0;
        foreach (int factor in factors){
            sumSquares += Math.Pow(factor, 2);
        }
        return sumSquares;
    }

  
 // Method to find sum of factors
  public static int SumOfFactors(int[] factors){
  int sum = 0;
  foreach (int factor in factors){
    sum += factor;
  }
  return sum;
  }
    
}
