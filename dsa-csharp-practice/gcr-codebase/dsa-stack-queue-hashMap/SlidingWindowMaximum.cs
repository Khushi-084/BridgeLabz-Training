using System;
using System.Collections.Generic;

// Given an array and a window size k, find the maximum element in each sliding window of size k.

class SlidingWindowMaximum{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter window size k: ");
        int k = int.Parse(Console.ReadLine());
        
        LinkedList<int> dq = new LinkedList<int>();   // Deque
    
        for (int i = 0; i < n; i++){
            if (dq.Count > 0 && dq.First.Value <= i - k)          // Removing the elements
                dq.RemoveFirst();       // that are outside the window

            while (dq.Count > 0 && arr[dq.Last.Value] <= arr[i])       // Removing the elements
                dq.RemoveLast();        // that are smaller than the current element

            dq.AddLast(i);      // Adding the current element

            
            if (i >= k - 1)       // Printing the elements
                Console.Write(arr[dq.First.Value] + " ");       //  that are inside the window
        }
    }
}
