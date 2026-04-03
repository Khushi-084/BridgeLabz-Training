using System;
using System.Collections.Generic;

// Given an array and a target sum, find two indices such that their values add up to the target.

class TwoSum{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target: ");
        int target = int.Parse(Console.ReadLine());

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < n; i++) {         // Traversing the list
            int diff = target - arr[i];       // Calculating the difference
            if (map.ContainsKey(diff))  {      // If the difference is present in the map 
                Console.WriteLine($"Indices: {map[diff]}, {i}");     // Print the indices
                return;
            }
            map[arr[i]] = i;         // Adding the element to the map
        }

        Console.WriteLine("No solution");
    }
}
