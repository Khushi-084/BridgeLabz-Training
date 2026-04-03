using System;

// An e-commerce company wants to display product prices in ascending order. 
// Implement Quick Sort in C# to sort the product prices.

class QuickSortProductPrice{
    // Function to partition the array
    static int Partition(int[] arr, int low, int high){
        int pivot = arr[high];    // Pivot element
        int i = low - 1;           // Index of smaller element

        for (int j = low; j < high; j++){       // Traversing the array
            if (arr[j] < pivot) {               // If the current element is smaller than the pivot
                i++;
                int temp = arr[i];            // Swapping
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int t = arr[i + 1];       // Swapping
        arr[i + 1] = arr[high];
        arr[high] = t;

        return i + 1;
    }

    // Function to sort the array
    static void QuickSort(int[] arr, int low, int high){
        if (low < high){              // If the left index is less than the right index
            int pi = Partition(arr, low, high);         // Partitioning the array
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    public static void Main(string[] args){
        // Input
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter product prices:");
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        QuickSort(prices, 0, n - 1);          // Calling the Quick Sort function
        

        // Output
        Console.WriteLine("Sorted Product Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}
