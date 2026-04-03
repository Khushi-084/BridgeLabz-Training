using System;
using System.Collections.Generic;

class ShoppingCart
{
    public static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();

        cart.Add("Laptop", 75000);
        cart.Add("Mouse", 800);
        cart.Add("Keyboard", 1500);

        Console.WriteLine("Cart:");
        foreach (KeyValuePair<string, double> item in cart)
            Console.WriteLine(item.Key + " : " + item.Value);

        SortedDictionary<double, string> sorted =
            new SortedDictionary<double, string>();

        foreach (KeyValuePair<string, double> item in cart)
            sorted[item.Value] = item.Key;

        Console.WriteLine("\nSorted by Price:");
        foreach (KeyValuePair<double, string> item in sorted)
            Console.WriteLine(item.Value + " : " + item.Key);
    }
}
