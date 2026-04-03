using System;
class Product{
    // Static field to store discount
    public static double Discount = 10;
    

    // Instance fields to store product details
    public string ProductName;
    public double Price;
    public int Quantity;
    public readonly int ProductID;
    
    // Parameterized constructor to initialize product details
    public Product(string productName, double price, int quantity, int productID){
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productID;
    }
    
    // Static method to update discount percentage
    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
    }
    
    // Instance method to display product details 
    public void DisplayDetails(object obj){
        // Checking if the object is of type Product
        if (obj is Product){
            // Displaying product details
            Console.WriteLine("\n--- Product Details ---");
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Product ID: " + ProductID);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Discount: " + Discount + "%");
        }
    }
}

class ShoppingCartSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Product Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Price: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        // Creating an object of the Product class
        Product.UpdateDiscount(15);
        
        // Displaying product details
        Product product = new Product(name, price, qty, id);
        product.DisplayDetails(product);
    }
}
