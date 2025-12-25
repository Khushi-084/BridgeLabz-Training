using System;
class RandomAverage{
  public static void Main(string[] args){

    // Generating array of 5 random 4-digit numbers
    Console.WriteLine("Generating 5 random 4-digit numbers");
    int[] numbers = GenerateRandomArray(5);
    Console.WriteLine("Generated Numbers:");
    foreach (int num in numbers){
      Console.WriteLine(num);
    }

    //  Finding average, min and max
    double[] results = AverageMinMax(numbers);
    Console.WriteLine("Result:");
    Console.WriteLine("Average = " + results[0]);
    Console.WriteLine("Minimum = " + results[1]);
    Console.WriteLine("Maximum = " + results[2]);
  }



// Method to find average, min and max
public static double[] AverageMinMax(int[] numbers){
  int min = numbers[0];
  int max = numbers[0];
  int sum = 0;
  foreach (int num in numbers){
    sum += num;
    min = Math.Min(min, num);
    max = Math.Max(max, num);
  }
  double average = (double)sum / numbers.Length;
  return new double[] { average, min, max };
  }


  // Method to generate array of 4-digit random numbers
  public static int[] GenerateRandomArray(int size){
  int[] arr = new int[size];
  Random rand = new Random();
  for (int i = 0; i < size; i++){
    arr[i] = rand.Next(1000, 10000);
  }
  return arr;
}
}
