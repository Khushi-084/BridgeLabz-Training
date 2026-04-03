using System;

// A company receives job applications with different expected salary demands. 
// Implement Heap Sort in C# to sort these salary demands in ascending order.

class HeapSortSalaries{
    // Function to heapify the array
    static void Heapify(int[] arr, int n, int i){
        int largest = i;          // Index of the largest element
        int left = 2 * i + 1;       // Index of the left child
        int right = 2 * i + 2;      // Index of the right child

        if (left < n && arr[left] > arr[largest])     // If the left child is greater than the parent
            largest = left;

        if (right < n && arr[right] > arr[largest])     // If the right child is greater than the parent
            largest = right;

        if (largest != i){           // If the largest element is not the parent
            int temp = arr[i];            // Swapping
            arr[i] = arr[largest];        
            arr[largest] = temp;
            Heapify(arr, n, largest);
        }
    }
    // Function to sort the array
    static void HeapSort(int[] arr){
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)      // Building the heap
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--) {         // Sorting the array
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            Heapify(arr, i, 0);
        }
    }

    public static void Main(string){
        // Input
        Console.Write("Enter number of applicants: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];
        Console.WriteLine("Enter expected salaries:");
        for (int i = 0; i < n; i++)
            salaries[i] = int.Parse(Console.ReadLine());

        HeapSort(salaries);       // Calling the Heap Sort function

        // Output
        Console.WriteLine("Sorted Salaries:");
        foreach (int s in salaries)
            Console.Write(s + " ");
    }
}
