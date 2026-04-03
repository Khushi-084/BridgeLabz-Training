using System;
class Program{
    public static void Main(string[] args){
        // Creating two food items 
        FoodItem f1 = new VegItem(200, 2);
        FoodItem f2 = new NonVegItem(300, 1);
        
        // Displaying total prices of food items
        System.Console.WriteLine(f1.CalculateTotalPrice());
        System.Console.WriteLine(f2.CalculateTotalPrice());
    }
}
