using System;

class Book{
    // Static field to store library name
    public static string LibraryName = "Central Library";
    
    // Instance fields to store book details
    public string Title;
    public string Author;
    public readonly string ISBN;
    
    // Parameterized constructor to initialize book details
    public Book(string title, string author, string isbn){
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
    
    // Static method to display library name
    public static void DisplayLibraryName(){
        Console.WriteLine("Library Name: " + LibraryName);
    }
    
    // Method to display book details
    public void DisplayDetails(object obj){
        // Check if the object is of type Book
        if (obj is Book){
            // Displaying book details
            Console.WriteLine("\n--- Book Details ---");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
}

class LibraryManagementSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        // Creating an object of the Book class
        Book book = new Book(title, author, isbn);
        
        // Displaying book details
        Book.DisplayLibraryName();
        book.DisplayDetails(book);
    }
}
