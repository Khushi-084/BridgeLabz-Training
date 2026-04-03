using System;
using System.Collections.Generic;

// For each day in a stock price array, calculate the span 
//(number of consecutive days the price was less than or equal to the current day's price).

class StockSpan{
    public static void Main(string[] args){
        // Input 
        Console.Write("Enter number of days: ");
        int n = int.Parse(Console.ReadLine());
        
    
        int[] price = new int[n];
        int[] span = new int[n];
        
        Console.WriteLine("Enter stock prices:");
        for (int i = 0; i < n; i++)    // Traversing the list
            price[i] = int.Parse(Console.ReadLine());
        
        Stack<int> st = new Stack<int>();
        st.Push(0); // Pushing the first element
        span[0] = 1;   // Span of the first element

        // Traversing the list
        for (int i = 1; i < n; i++){
            while (st.Count > 0 && price[st.Peek()] <= price[i])    
                st.Pop(); // Popping the elements

            span[i] = (st.Count == 0) ? i + 1 : i - st.Peek();    
            st.Push(i);
        }
        
        // Output
        Console.WriteLine("Stock Span:");
        for (int i = 0; i < n; i++)
            Console.Write(span[i] + " ");
    }
}
