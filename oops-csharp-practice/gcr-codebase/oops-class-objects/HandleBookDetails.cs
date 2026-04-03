using System;
class Book{
    // Attributes of the Book class
    string title;
    string author;
    double price;
    
    // Constructor to initialize attributes
    public Book(string title, string author, double price){
        this.title = title;         // this represents the current object
        this.author = author;
        this.price = price;
    }
    
    // Method to display book details
    public void DisplayDetails(){
        Console.WriteLine("\n--- Book Details ---");
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = double.Parse(Console.ReadLine());

        // Creating an object of the Book class
        Book book = new Book(title, author, price);
        // Displaying book details
        book.DisplayDetails();
    }
}
