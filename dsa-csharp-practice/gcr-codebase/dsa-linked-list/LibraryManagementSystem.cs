using System;
// Represents a node in the library doubly linked list
class BookNode{
    // Fields of the class
    public int Id;
    public string Title,Author;
    public bool Available;
    public BookNode next,prev;
}

// Manages the library using a doubly linked list
class Library{
    // Field of the class
    BookNode head;

    // Adds a new book to the front of the list
    public void Add(int id,string title,string author){ 
        BookNode node=new BookNode{Id=id,Title=title,Author=author,Available=true};   // Creates a new node
        node.next=head;      // Adding at the beginning
        if (head != null){     // If the list is not empty
            head.prev=node;
        }
        head=node;
    }

    // Counts and prints the total number of books
    public void Count(){
        int count=0;
        BookNode temp=head;
        while (temp != null){      // Traversing the list
            count++;
            temp=temp.next;
        }
        Console.WriteLine("Total Books: " + count);
    }
}

// Main class to demonstrate the library system
class LibraryMain{
    static void Main(string[] args){
        Library lib=new Library();
        lib.Add(1,"Java","MS");
        lib.Add(2,"DSA","CLRS");
        lib.Count();
    }
}