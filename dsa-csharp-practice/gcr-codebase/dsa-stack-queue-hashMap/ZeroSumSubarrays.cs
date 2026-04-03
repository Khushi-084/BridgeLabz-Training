using System;
using System.Collections.Generic;

// Given an array, find all subarrays whose elements sum up to zero.

class ZeroSumSubarrays{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());
        
        
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        bool found = false;
        
        // Traversing the list 
        for (int i = 0; i < n; i++){
            sum += arr[i];         // Calculate sum of elements
            if (sum == 0 || map.ContainsKey(sum))         // If sum is 0 or map contains sum
                found = true;

            if (!map.ContainsKey(sum))              // If map does not contain sum
                map[sum] = 1;
        }
        
        // Output
        Console.WriteLine(found ? "Zero sum subarray exists" : "No zero sum subarray");
    }
}
