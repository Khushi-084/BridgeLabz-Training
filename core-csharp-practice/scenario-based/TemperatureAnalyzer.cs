using System;
class TemperatureAnalyzer{
  static void Main(string[] args){
    float[,] temp = new float[7, 24];      // 7 days, 24 hours 
    Random random = new Random();
    for (int i = 0; i < 7; i++){
      for (int j = 0; j < 24; j++){
        temp[i, j] = random.Next(0, 41); 
      }
    }
    int value;
    do{
      Console.WriteLine("\n------------ Temperature Analyzer Menu ------------");
      Console.WriteLine("1. Find Hottest Day");
      Console.WriteLine("2. Find Coldest Day");
      Console.WriteLine("3. Average Temperature per Day");
      Console.WriteLine("4. Exit");
      Console.Write("Enter your value: ");
      value = int.Parse(Console.ReadLine());
      switch (value){
        case 1:
        FindHottestDay(temp);
        break;
        case 2:
        FindColdestDay(temp);
        break;
        case 3:
        AverageTemperature(temp);
        break;
        case 4:
        Console.WriteLine("Program finished");
        break;
        default:
        Console.WriteLine("Invalid input");
        break;
      }
    } while (value != 4);
  }
  //method to find hottest day
  static void FindHottestDay(float[,] temp){
    float max = temp[0, 0];
    int day = 0;
    for (int i = 0; i < 7; i++){
      for (int j = 0; j < 24; j++){
        if (temp[i, j] > max){
          max = temp[i, j];
          day = i;
        }
      }
    }
    Console.WriteLine($"Hottest Day: Day {day + 1} ({max})degree celsius");
  }

  //method to find coldest day
  static void FindColdestDay(float[,] temp){
    float min = temp[0, 0];
    int day = 0;
    for (int i = 0; i < 7; i++){
      for (int j = 0; j < 24; j++){
        if (temp[i, j] < min){
          min = temp[i, j];
          day = i;
        }
      }
    }
    Console.WriteLine($"Coldest Day: Day {day + 1} ({min} degree celsius)");
  }

  //method to find average temperature
  static void AverageTemperature(float[,] temp){
    for (int i = 0; i < 7; i++){
      float sum = 0;
      for (int j = 0; j < 24; j++){
        sum += temp[i, j];
      }
      Console.WriteLine($"Day {i + 1} Average = {sum / 24} degree celsius");
    }
  }
}