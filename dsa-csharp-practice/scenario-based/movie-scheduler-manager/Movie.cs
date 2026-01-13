using System;
// Encapsulated Movie class 
public class Movie{
    // properties with getters and setters
    public string Title { get; private set; }
    public string Time { get; private set; }

    //constructor to initialize movie object
    public Movie(string title, string time){
        Title = title;       // Set title
        Time = time;         // Set time
    }

    // Override ToString for easy display
    public override string ToString(){
        return "Movie: " + Title + " | Time: " + Time;      // Return movie details
    }
}
