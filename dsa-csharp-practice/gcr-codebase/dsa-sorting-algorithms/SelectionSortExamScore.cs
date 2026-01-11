// A university needs to sort students’ exam scores in ascending order. 
//Implement Selection Sort in C# to achieve this.

using System;

class SelectionSortExamScore{
    public static void Main(string[] args){
        // Input
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];
        Console.WriteLine("Enter exam scores:");
        for (int i = 0; i < n; i++)
            scores[i] = int.Parse(Console.ReadLine());
        
        // Selection Sort
        for (int i = 0; i < n - 1; i++) {        // n-1 passes
            int minIndex = i;                    // Index of minimum element
            for (int j = i + 1; j < n; j++)      // Traversing the array
                if (scores[j] < scores[minIndex])     // Finding the minimum element
                    minIndex = j;

            int temp = scores[i];                   // Swapping
            scores[i] = scores[minIndex];
            scores[minIndex] = temp;
        } 
        
        // Output
        Console.WriteLine("Sorted Exam Scores:");
        foreach (int s in scores)
            Console.Write(s + " ");
    }
}

