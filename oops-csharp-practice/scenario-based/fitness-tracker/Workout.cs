// Abstract class Workout
// Implements ITrackable
abstract class Workout : ITrackable{
    // Fields to store workout details 
    protected string workoutName;
    protected int duration; // in minutes

    public Workout(string workoutName, int duration){
        // Constructor to initialize workout details
        this.workoutName = workoutName;
        this.duration = duration;
    }
    
    // Abstract method to track workout progress
    public abstract void TrackWorkout();
}
