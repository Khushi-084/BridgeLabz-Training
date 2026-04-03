using System;
using System.Collections.Generic;

// to find the symmetric difference of two given sets
class SymmetricDifference{
    public static void Main(string[] args)
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();
        Console.Write("Enter number of elements in Set 1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(Convert.ToInt32(Console.ReadLine()));
        }
        HashSet<int> symmetricDifference = new HashSet<int>(set1);
        // Remove common elements
        symmetricDifference.SymmetricExceptWith(set2);
        Console.WriteLine("Symmetric Difference:");
        foreach (int item in symmetricDifference)
        {
            Console.Write(item + " ");
        }
    }
}
