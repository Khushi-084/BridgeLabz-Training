using System;
using System.Collections.Generic;

// Given a stack, sort its elements in ascending order using recursion.

class SortingOfStack{
    // Function to insert an element into the stack in sorted order
    static void InsertSorted(Stack<int> st, int x){
        if (st.Count == 0 || st.Peek() <= x){
            st.Push(x);
            return;
        }
        
        // If the stack is not empty and the top element is greater than x
        int temp = st.Pop();
        InsertSorted(st, x);
        st.Push(temp);
    }
    // Function to sort the stack in ascending order
    static void Sort(Stack<int> st){
        if (st.Count == 0)
            return;
        // If the stack is not empty
        int x = st.Pop();
        Sort(st);
        InsertSorted(st, x);
    }

    public static void Main(string[] args){
        // Input
        Stack<int> st = new Stack<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            st.Push(int.Parse(Console.ReadLine()));
        
        // Output(Sorted Stack)
        Sort(st);

        Console.WriteLine("Sorted Stack:");
        while (st.Count > 0)
            Console.Write(st.Pop() + " ");
    }
}
