// Given an array and a target sum, find if there exists a pair of elements 
//whose sum is equal to the target.

using System;
using System.Collections.Generic;

class PairWithGivenSum{
    public static void Main(string[] args){
        // Input
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        HashSet<int> set = new HashSet<int>();
        
        // Traversing the list and finding the pair
        foreach (int x in arr){
            if (set.Contains(target - x)){     // If the difference of x and target is present in the set
                Console.WriteLine("Pair Found");   // Print the pair
                return;
            }
            set.Add(x);       // Adding the element to the set
        }

        Console.WriteLine("No Pair Found");          // If no pair is found
    }
}

