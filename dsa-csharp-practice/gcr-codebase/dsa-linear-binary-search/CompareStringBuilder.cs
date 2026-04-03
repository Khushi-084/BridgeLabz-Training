using System;
using System.Diagnostics;
using System.Text;

// Compare performance of String vs StringBuilder for concatenation
class CompareStringBuilder{
    public static void Main(StringBuilder[] args){
        Stopwatch sw = new Stopwatch();

        sw.Start();  // Measuring String concatenation time
        StringBuilder sb = new StringBuilder();  // Using StringBuilder for better performance
        for (int i = 0; i < 100000; i++)  
            sb.Append("A");
        sw.Stop();  // Stop measuring time

        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
