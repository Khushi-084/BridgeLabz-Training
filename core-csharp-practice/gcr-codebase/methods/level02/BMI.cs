using System;
class BMI{

  public static void Main(string[] args){
    int totalPerson = 10;
    double[,] arr = new double[totalPerson, 3];

    // Input weight and height for each person
    for (int i = 0; i < totalPerson; i++){
      Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
      arr[i, 0] = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
      arr[i, 1] = Convert.ToDouble(Console.ReadLine());
    }

    // Calculating BMI
    CalculateBMI(arr, totalPerson);
    string[] status = DetermineBMIStatus(arr, totalPerson);
    Console.WriteLine("\nPerson\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
    for (int i = 0; i < totalPerson; i++){
      Console.WriteLine((i + 1) + "\t" + arr[i, 0] + "\t\t" + arr[i, 1] + "\t\t" + Math.Round(arr[i, 2], 2) + "\t\t" + status[i]);
    }
  }


  // Method to calculate BMI for each person
  public static void CalculateBMI(double[,] arr, int totalPerson){
  for (int i = 0; i < totalPerson; i++){
    double weight = arr[i, 0]; 
    double heightCm = arr[i, 1];
    double heightM = heightCm / 100;
    double bmi = weight / (heightM * heightM);
    arr[i, 2] = bmi; 
  }
}
// Method to determine BMI status for each person
  public static string[] DetermineBMIStatus(double[,] arr, int totalPerson){
    string[] status = new string[totalPerson];
      for (int i = 0; i < totalPerson; i++){
        double bmi = arr[i, 2];
        if (bmi < 18.5)
          status[i] = "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
          status[i] = "Normal weight";
        else if (bmi >= 25 && bmi < 29.9)
          status[i] = "Overweight";
        else
          status[i] = "Obese";
      }
    return status;
  }
}
