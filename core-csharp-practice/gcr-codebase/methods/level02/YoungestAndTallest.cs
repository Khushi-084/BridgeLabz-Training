using System;
class YoungestAndTallest{
 public static void Main(string[] args){

  // Input age and height
  string[] arr1 = { "Amar", "Akbar", "Anthony" };
  int[] arr2 = new int[3];
  double[] heights = new double[3];        
  for (int i = 0; i < 3; i++){
    Console.Write("Enter age of " + arr1[i] + ": ");
    arr2[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter height of " + arr1[i] + " (in cm): ");
    heights[i] = Convert.ToDouble(Console.ReadLine());
  }


  // Finding the youngest and tallest member
  string youngest = FindYoungest(arr1, arr2);
  string tallest = FindTallest(arr1, heights);
  Console.WriteLine("The youngest friend is: " + youngest);
  Console.WriteLine("The tallest friend is: " + tallest);
  }


   
    // Method to find the tallest friend
    public static string FindTallest(string[] arr1, double[] heights){
    double maximumHeight = heights[0];
    string tallest = arr1[0];
    for (int i = 1; i < heights.Length; i++){
      if (heights[i] > maximumHeight){
        maximumHeight = heights[i];
        tallest = arr1[i];
      }
    }
    return tallest;
  }

   // Method to find the youngest friend
    public static string FindYoungest(string[] arr1, int[] arr2){
      int minimumAge = arr2[0];
      string youngest = arr1[0];
      for (int i = 1; i < arr2.Length; i++){
        if (arr2[i] < minimumAge){
          minimumAge = arr2[i];
          youngest = arr1[i];
        }
      }
      return youngest;
    }
}
