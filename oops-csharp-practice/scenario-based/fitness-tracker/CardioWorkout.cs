// CardioWorkout class
// Inherits from Workout 
class CardioWorkout : Workout{
    // Fields 
    private double distance; // in km
    
    // Constructor 
    public CardioWorkout(string workoutName, int duration, double distance)
        : base(workoutName, duration)
    {
        // Initialize CardioWorkout fields 
        this.distance = distance;
    }
    
    // Method to track CardioWorkout 
    public override void TrackWorkout(){
        // Track CardioWorkout 
        Console.WriteLine("Cardio Workout Details:");
        Console.WriteLine($"Workout: {workoutName}");
        Console.WriteLine($"Duration: {duration} minutes");
        Console.WriteLine($"Distance: {distance} km");
    }
}
