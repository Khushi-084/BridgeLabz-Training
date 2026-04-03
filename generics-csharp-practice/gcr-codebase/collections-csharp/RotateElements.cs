using System;
using System.Collections.Generic;
class RotateElements{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        Console.Write("Enter number of elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }
        Console.Write("Enter rotation count: ");
        int k = Convert.ToInt32(Console.ReadLine());
         // Handle rotations greater than list size
        k = k % n;                                             
        List<int> rotatedList = new List<int>();
        for (int i = k; i < n; i++)
        {
            rotatedList.Add(list[i]);
        }
        for (int i = 0; i < k; i++)
        {
            rotatedList.Add(list[i]);
        }
        Console.WriteLine("Rotated List:");
        foreach (int item in rotatedList)
        {
            Console.Write(item + " ");
        }
    }
}
