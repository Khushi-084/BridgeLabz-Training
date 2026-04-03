using System;
using System.Collections.Generic;

// Given an unsorted array, find the length of the longest consecutive elements sequence.

class LongestConsecutiveSequence{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        HashSet<int> set = new HashSet<int>(arr);      // Converting the array to a set 
        int longest = 0;        // Longest consecutive sequence 

        foreach (int num in set){
            if (!set.Contains(num - 1)){ // If the current element is the start of a consecutive sequence
                int curr = num;          // Current element
                int count = 1;            // Count of consecutive elements

                while (set.Contains(curr + 1)){    // Traversing the consecutive sequence
                    curr++;        // Incrementing the current element
                    count++;       // Incrementing the count
                }
                
                // Updating the longest consecutive sequence
                longest = Math.Max(longest, count);
            }
        }
        
        // Output 
        Console.WriteLine("Longest Consecutive Length: " + longest);
    }
}
