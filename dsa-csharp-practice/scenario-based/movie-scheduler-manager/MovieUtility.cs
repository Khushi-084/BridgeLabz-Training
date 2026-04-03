using System;

// Utility class
public class MovieUtility : IMovieService{
    // Internal storage for movies
    private Movie[] movies = new Movie[50];
    private int count = 0;

    // Add movie only if time format is valid
    public void AddMovie(string title, string time){
        if (!IsValidTime(time)){
            Console.WriteLine("Invalid time format. Use HH:MM.");
            return;
        }

        movies[count++] = new Movie(title, time);        // Add movie
        Console.WriteLine("Movie added successfully.");
    }
    // Linear search using String.Contains()
    public void SearchMovie(string keyword){
        bool found = false;


        for (int i = 0; i < count; i++){
            if (movies[i].Title.Contains(keyword)){     // Check if title contains keyword
                Console.WriteLine(movies[i]);           // Display movie details
                found = true;                           // Mark as found
            }
        }

        if (!found){
            Console.WriteLine("No movie found.");
        }
    }
    // Display all movies in storage
    public void DisplayAllMovies(){
        for (int i = 0; i < count; i++)          // Iterate through movies
            Console.WriteLine((i + 1) + ". " + movies[i]);     // Display movie details
    }

   
    // Manual time validation (no exception handling)
    private bool IsValidTime(string time){
        if (time.Length != 5 || time[2] != ':'){       // Basic format check
            return false;
        }
        int hour = int.Parse(time.Substring(0, 2));
        int min = int.Parse(time.Substring(3, 2));
        return hour >= 0 && hour <= 23 && min >= 0 && min <= 59;
    }
}
