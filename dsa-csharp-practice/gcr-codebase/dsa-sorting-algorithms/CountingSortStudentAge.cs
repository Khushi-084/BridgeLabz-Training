using System;

// A school collects students’ ages (ranging from 10 to 18) and wants them sorted.
// Implement Counting Sort in C# for this task.

class CountingSortStudentAge{
    public static void Main(string[] args){
        // Input
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];
        Console.WriteLine("Enter student ages (10-18):");
        for (int i = 0; i < n; i++)
            ages[i] = int.Parse(Console.ReadLine());

        int[] count = new int[19];     // Counting sort
        
        // Counting
        for (int i = 0; i < n; i++)
            count[ages[i]]++;
        
        // Output
        Console.WriteLine("Sorted Ages:");
        for (int age = 10; age <= 18; age++)
            while (count[age]-- > 0)
                Console.Write(age + " ");
    }
}
