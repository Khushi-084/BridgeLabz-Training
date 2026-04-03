using System;

// A company stores employee IDs in an unsorted array. 
// Implement Insertion Sort in C# to sort the employee IDs in ascending order.

class InsertionSortEmployeeID{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] empIds = new int[n];
        Console.WriteLine("Enter employee IDs:");
        for (int i = 0; i < n; i++)
            empIds[i] = int.Parse(Console.ReadLine());

        // Insertion Sort
        for (int i = 1; i < n; i++){         // Traversing the list
            int key = empIds[i];             // Key
            int j = i - 1;                   // Index

            while (j >= 0 && empIds[j] > key){           // Swapping
                empIds[j + 1] = empIds[j];               
                j--;
            }
            empIds[j + 1] = key;     // Inserting the key
        }
        
        // Output 
        Console.WriteLine("Sorted Employee IDs:");
        foreach (int id in empIds)
            Console.Write(id + " ");
    }
}
