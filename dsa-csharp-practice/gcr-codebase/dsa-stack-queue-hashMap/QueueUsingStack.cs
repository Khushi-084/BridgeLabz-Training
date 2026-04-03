using System;
using System.Collections.Generic;

// Design a queue using two stacks such that enqueue and dequeue operations are performed efficiently.

class QueueUsingStacks{
    // Stacks to implement queue
    static Stack<int> s1 = new Stack<int>();
    static Stack<int> s2 = new Stack<int>();
    

    // Enqueues an element into the queue
    static void Enqueue(int x){
        s1.Push(x);
    }
    
    // Dequeues an element from the queue 
    static int Dequeue(){
        if (s2.Count == 0){
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }

        if (s2.Count == 0)
            return -1;

        return s2.Pop();
    }

    
    public static void Main(string[] args){
        // Input
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            Enqueue(int.Parse(Console.ReadLine()));
        
        // Output
        Console.WriteLine("Dequeued element: " + Dequeue());
    }
}
