// A bookstore maintains a list of book prices in an array. 
// Implement Merge Sort in C# to sort the prices in ascending order.

using System;

class MergeSortBookPrices{
    // Function to sort an array using Merge Sort
    static void MergeSort(int[] arr, int left, int right){
        if (left < right){           // If the left index is less than the right index
            int mid = (left + right) / 2;        // Finding the middle index
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }
    
    // Function to merge two sorted arrays
    static void Merge(int[] arr, int left, int mid, int right){
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)          // Traversing the left array
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)          // Traversing the right array
            R[j] = arr[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)            // Merging the arrays
            arr[k++] = (L[iIndex] <= R[jIndex]) ? L[iIndex++] : R[jIndex++];

        while (iIndex < n1)                // Adding the remaining elements
            arr[k++] = L[iIndex++];

        while (jIndex < n2)                // Adding the remaining elements
            arr[k++] = R[jIndex++];
    }

    public static void Main(string [] args){
        // Input
        Console.Write("Enter number of books: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter book prices:");
        for (int i = 0; i < n; i++)
            prices[i] = int.Parse(Console.ReadLine());

        MergeSort(prices, 0, n - 1);        // Calling the Merge Sort function
        
        // Output
        Console.WriteLine("Sorted Book Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
    }
}

