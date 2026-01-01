using System;
class Book{
    // Attributes
    public string ISBN;          // public
    protected string title;      // protected
    private string author;       // private

    // Constructor with parameters
    public Book(string isbn, string title, string author){
        this.ISBN = isbn;
        this.title = title;
        this.author = author;
    }

    // Setter for private author
    public void SetAuthor(string author){
        this.author = author;
    }

    // Getter for private author
    public string GetAuthor(){
        return author;
    }
}

// Subclass of Book
class EBook : Book{
    public EBook(string isbn, string title, string author)
        : base(isbn, title, author) { }
    
    // Method to display book details
    public void Display(){
        Console.WriteLine("\nISBN: " + ISBN);   // public
        Console.WriteLine("Title: " + title);  // protected
        Console.WriteLine("Author: " + GetAuthor());
    }
}

class BookLibrarySystem{
    public static void Main(string[] args){ 
        // Creating an object of the EBook class
        EBook ebook = new EBook("978-12345", "C# Guide", "John Smith");
        // Displaying book details
        ebook.Display();
    }
}
