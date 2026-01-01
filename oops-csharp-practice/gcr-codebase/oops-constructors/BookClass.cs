using System;
class Book{
    // Attributes of the Book class
    public string Title;
    public string Author;
    public double Price;

    // Default constructor
    public Book(){
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
    }

    // Parameterized constructor
    public Book(string title, string author, double price){
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    // Method to display book details
    public void DisplayDetails(){
        Console.WriteLine("\n--- Book Details ---");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }
}

class BookClass{
    public static void Main(string[] args){
        // Using default constructor
        Book book1 = new Book();
        book1.DisplayDetails();

        // Taking input from user for parameterized constructor
        Console.Write("\nEnter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter Book Price: ");
        double price = double.Parse(Console.ReadLine());
        
        // Using parameterized constructor
        Book book2 = new Book(title, author, price);
        // Displaying book details
        book2.DisplayDetails();
    }
}
