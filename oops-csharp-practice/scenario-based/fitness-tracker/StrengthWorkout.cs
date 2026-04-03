// Class StrengthWorkout that inherits from Workout
class StrengthWorkout : Workout{
    // Private fields for sets and reps
    private int sets;
    private int reps;
    
    // Constructor 
    public StrengthWorkout(string workoutName, int duration, int sets, int reps)
        : base(workoutName, duration)
    {
        // Initialize StrengthWorkout fields 
        this.sets = sets;
        this.reps = reps;
    }
    // Method to track StrengthWorkout  
    public override void TrackWorkout(){
        Console.WriteLine("Strength Workout Details:");
        Console.WriteLine($"Workout: {workoutName}");
        Console.WriteLine($"Duration: {duration} minutes");
        Console.WriteLine($"Sets: {sets}, Reps: {reps}");
    }
}
