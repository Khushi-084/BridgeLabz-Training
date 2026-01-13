using System;
// Find first missing positive integer using Linear Search and Binary Search
class PositiveInteger{
    public static void Main(String[] args){
        // -------- Input --------
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];     // Declare array

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }
        //  Linear Search for First Missing Positive Integer
        int firstMissing = FindFirstMissingPositive(arr);
        Console.WriteLine($"\nFirst Missing Positive Number: {firstMissing}");

        // Binary Search for Target Index 
        Console.Write("\nEnter target value to search: ");
        int target = int.Parse(Console.ReadLine());

        // Sort the array before binary search
        Array.Sort(arr); 

        // Perform binary search
        int index = BinarySearch(arr, target);
        if (index != -1){        // Target found
            Console.WriteLine($"Target {target} found at index {index} (after sorting).");
        }else{
            Console.WriteLine("Target not found in the array.");
        }
    }

    // Linear Search Method to find first missing positive integer
    static int FindFirstMissingPositive(int[] nums){
        int n = nums.Length;
        bool[] visited = new bool[n + 1];    // Array to track visited positive numbers
        // Mark visited positive numbers
        for (int i = 0; i < n; i++){
            if (nums[i] > 0 && nums[i] <= n){           // Check bounds
                visited[nums[i]] = true;                // Mark as visited
            }
        }
        // Find first missing positive
        for (int i = 1; i <= n; i++){
            if (!visited[i])                            // Check for first unvisited
                return i;
        }

        return n + 1;
    }

    // Binary Search Method to find target index
    static int BinarySearch(int[] arr, int target){
        int left = 0;
        int right = arr.Length - 1;    
        while (left <= right){                      // Binary search loop
            int mid = (left + right) / 2;           // Calculate mid index
            if (arr[mid] == target){                // Check if target is found
                return mid;                         // Return index
            }
            else if (arr[mid] < target){            // Check which side to search
                left = mid + 1;                   // Move left pointer
            }
            else{
                right = mid - 1;                 // Move right pointer
            }
        }
        return -1;
    }
}
