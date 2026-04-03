using System;

// Program to find a peak element in an array
class FindPeakElement{
    public static void Main(string[] args){
        // Get array size from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];    // Declare array

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)        
            arr[i] = int.Parse(Console.ReadLine());
        
        // Binary search for peak element
        int low = 0, high = n - 1;

        while (low < high){                  // Continue until low meets high
            int mid = (low + high) / 2;      // Calculate mid index

            if (arr[mid] < arr[mid + 1])     // Check if mid is less than next element
                low = mid + 1;               // Move low pointer
            else
                high = mid;                  // Move high pointer
        }

        Console.WriteLine("Peak element index: " + low);
        Console.WriteLine("Peak element value: " + arr[low]);
    }
}
