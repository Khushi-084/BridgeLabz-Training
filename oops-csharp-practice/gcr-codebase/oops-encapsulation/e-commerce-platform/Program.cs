using System;

class Program{
    public static void Main(string[] args){
        // Creating three products
        Product p1 = new Electronics("Laptop", 60000);
        Product p2 = new Clothing("Jacket", 4000);
        Product p3 = new Groceries("Rice", 1000);
        
        // Displaying final prices
        Console.WriteLine($"Final Price: {p1.GetFinalPrice()}");
        Console.WriteLine($"Final Price: {p2.GetFinalPrice()}");
        Console.WriteLine($"Final Price: {p3.GetFinalPrice()}");
    }
}
