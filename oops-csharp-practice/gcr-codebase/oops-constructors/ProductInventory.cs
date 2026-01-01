using System;
class Product{
    // Instance variables
    string productName;
    double price;

    // Class variable (shared among all products)
    static int totalProducts = 0;

    // Constructor with parameters
    public Product(string productName, double price){
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    // Instance method to display product details
    public void DisplayProductDetails(){
        Console.WriteLine("\nProduct Name: " + productName);
        Console.WriteLine("Price: " + price);
    }

    // Class method to display total number of products created 
    public static void DisplayTotalProducts(){
        Console.WriteLine("\nTotal Products Created: " + totalProducts);
    }
}

class ProductInventory{
    public static void Main(string[] args){
        // Creating two products
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mobile", 20000);

        // Displaying product details
        p1.DisplayProductDetails();
        p2.DisplayProductDetails();
        
        // Displaying total number of products
        Product.DisplayTotalProducts();
    }
}
