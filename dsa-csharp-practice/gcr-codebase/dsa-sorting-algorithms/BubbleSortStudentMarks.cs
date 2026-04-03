using System;

// A school maintains student marks in an array. 
// Implement Bubble Sort in C# to sort the student marks in ascending order.

class BubbleSortStudentMarks{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];
        Console.WriteLine("Enter student marks:");
        for (int i = 0; i < n; i++)
            marks[i] = int.Parse(Console.ReadLine());

        // Bubble Sort
        for (int i = 0; i < n - 1; i++){              // n-1 passes
            for (int j = 0; j < n - i - 1; j++){        // n-i-1 comparisons
                if (marks[j] > marks[j + 1]){        // Swapping
                    int temp = marks[j];              
                    marks[j] = marks[j + 1];       
                    marks[j + 1] = temp;
                }
            }
        }
        
        // Output 
        Console.WriteLine("Sorted Marks:");
        foreach (int m in marks)
            Console.Write(m + " ");
    }
}
