using System;

// Encapsulated Book class
    class Book{
        public string Title { get; private set; }
        public string Author { get; private set; }
 
        // Constructor to initialize book object
        public Book(string title, string author){
            Title = title;          // Set title
            Author = author;        // Set author
        }

        // Format book details for display/export
        public string GetFormattedBook(){
            return Title + " - " + Author;
        }
    }
