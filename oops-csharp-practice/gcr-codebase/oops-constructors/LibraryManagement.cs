using System;
class Book{
    // Attributes of a book
    public string Title;
    public string Author;
    public double Price;
    public bool IsAvailable;

    // Parameterized constructor
    public Book(string title, string author, double price){
        this.Title = title;    // this represents the current object
        this.Author = author;
        this.Price = price;
        this.IsAvailable = true; // Available by default
    }

    // Method to borrow book
    public void BorrowBook(){
        if (IsAvailable){           // Check if book is available
            IsAvailable = false;
            Console.WriteLine($"You have successfully borrowed '{Title}'.");
        }
        else{
            Console.WriteLine($"Sorry, '{Title}' is currently not available.");
        }
    }
    
    // Method to display book details
    public void DisplayDetails(){
        Console.WriteLine($"\nTitle: {Title}, Author: {Author}, Price: {Price}, Available: {IsAvailable}");
    }
}

class LibraryManagement{
    public static void Main(string[] args){
        // Create a book
        Book book1 = new Book("C# Basics", "John Doe", 499);
        // Display book details
        book1.DisplayDetails();
        // Borrow the book
        book1.BorrowBook();
        // Display book details
        book1.DisplayDetails();
        
        // Try to borrow again
        book1.BorrowBook();
    }
}
