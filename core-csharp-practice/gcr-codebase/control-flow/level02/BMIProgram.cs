using System;
class BMIProgram{
  public static void Main(string[] args){
    // Taking weight and height input from user
    Console.WriteLine("Enter your weight (in kg):");
    double weight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your height (in cm):");
    double heightCm = Convert.ToDouble(Console.ReadLine());


    // Converting height from cm to meters
    double heightMeter = heightCm / 100;


    // Calculating BMI
    double bmi = weight / (heightMeter * heightMeter);
    Console.WriteLine("\nYour BMI is: " + bmi);


    // Determining BMI status and printing the result
    if (bmi <= 18.4){
      Console.WriteLine("Status: Underweight");
    }else if (bmi >= 18.5 && bmi <= 24.9){
      Console.WriteLine("Status: Normal");
    }else if (bmi >= 25.0 && bmi <= 39.9){
      Console.WriteLine("Status: Overweight");
    }else{
      Console.WriteLine("Status: Obese");
    }
  }
}
