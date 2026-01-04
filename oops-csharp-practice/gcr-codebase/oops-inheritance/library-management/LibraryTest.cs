using System;

class LibraryTest{
    public static void Main(string[] args){
        Author author = new Author{
            // Calling the base class constructor
            Title = "Clean Code",
            PublicationYear = 2008,
            Name = "Robert C. Martin",
            Bio = "Software Engineer and Author"
        };
        
        // Calling the derived class method
        author.DisplayInfo();
    }
}
