using System;

class StudentScore{
    public static void Main(){
        int num;
        Console.Write("Enter number of students: ");   // Taking number of students
        num=int.Parse(Console.ReadLine());
        if (num <= 0){
            Console.WriteLine("Invalid number of students.");  // Invalid input
            return;
        }

        int[] arr = new int[num];
        int sum = 0;

        // Taking input as scores of each student
        for (int i = 0; i < num; i++){
            arr[i]=int.Parse(Console.ReadLine());
            sum += arr[i];
        }
        // Calculate average
        double average = (double)sum / num;

        // Find highest and lowest
        int highest = arr[0];
        int lowest = arr[0];

        for (int i = 1; i < num; i++){  
            if (arr[i] > highest)
                highest = arr[i];

            if (arr[i] < lowest)
                lowest = arr[i];
        }

        // Output results
        Console.WriteLine("\nAverage Score: " + average);
        Console.WriteLine("Highest Score: " + highest);
        Console.WriteLine("Lowest Score: " + lowest);

        Console.WriteLine("Scores above average:");        // Scores above average
        bool found = false;

        for (int i = 0; i < num; i++){
            if (arr[i] > average)
            {
                Console.WriteLine(arr[i]);
                found = true;
            }
        }

        if (!found){            // No scores above average
            Console.WriteLine("No scores above average.");
        }
    }
}