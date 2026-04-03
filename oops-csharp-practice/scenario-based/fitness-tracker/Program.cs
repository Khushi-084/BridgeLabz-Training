using System;

class Program{
    public static void Main(string[] args){
        // Creating user profile and tracking workouts
        UserProfile user = new UserProfile("Khushi", 21);
        user.DisplayUser();

        Console.WriteLine();
        
        // Creating and tracking workouts
        Workout cardio = new CardioWorkout("Running", 30, 5.2);
        Workout strength = new StrengthWorkout("Weight Training", 45, 4, 12);

        // Tracking workouts 
        cardio.TrackWorkout();
        Console.WriteLine();
        strength.TrackWorkout();
    }
}
