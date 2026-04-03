using System;

class MovieNode{
    // Instance variables of the class
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode Prev, Next;
    
    // Constructor of the class 
    public MovieNode(string title, string director, int year, double rating){
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
    }
}
// Class MovieList
class MovieList{
    // Instance variables of the class
    private MovieNode head, tail;

    // Constructor of the class 
    public void AddAtEnd(string title, string director, int year, double rating){
        MovieNode node = new MovieNode(title, director, year, rating);
        if (head == null) // If the list is empty
            head = tail = node;
        else {
            tail.Next = node;    // Adding at the end
            node.Prev = tail;   
            tail = node;
        }
    }
    
    // Remove a movie by title 
    public void RemoveByTitle(string title){
        MovieNode temp = head;
        while (temp != null){    // Traversing the list
            if (temp.Title == title){     // If the movie is found
                if (temp.Prev != null)           // If the movie is not the first movie
                    temp.Prev.Next = temp.Next;
                else
                    head = temp.Next;

                if (temp.Next != null)         // If the movie is not the last movie
                    temp.Next.Prev = temp.Prev;
                else
                    tail = temp.Prev;          // If the movie is the last movie
                return;
            }
            temp = temp.Next;
        }
    }
    
    // Display the list of movies
    public void DisplayForward(){
        MovieNode temp = head;
        while (temp != null){
            Console.WriteLine($"{temp.Title} | {temp.Director} | {temp.Rating}");
            temp = temp.Next;
        }
    }
    
    // Display the list of movies in reverse
    public void DisplayReverse(){
        MovieNode temp = tail;
        while (temp != null){
            Console.WriteLine($"{temp.Title} | {temp.Director} | {temp.Rating}");
            temp = temp.Prev;
        }
    }
}
