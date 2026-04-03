using System;

// Program to find the rotation point in a rotated sorted array
class RotationPointInSortedArray{
    public static void Main(string[] args){
        // Get array size from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];  // Declare array

        // Get rotated sorted array from user
        Console.WriteLine("Enter rotated sorted array:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int low = 0, high = n - 1;         // Initialize low and high pointers

        while (low < high){                // Binary search for rotation point
            int mid = (low + high) / 2;    // Calculate mid index

            if (arr[mid] > arr[high])       // Check which side to search
                low = mid + 1;              // Move low pointer
            else
                high = mid;                 // Move high pointer
        }

        Console.WriteLine("Rotation point index: " + low);
    }
}
