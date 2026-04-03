using System;
// Interface for movie operations
public interface IMovieService{
    // Add a new movie with title and time
    void AddMovie(string title, string time);
    void SearchMovie(string keyword);
    void DisplayAllMovies();
   
}
