class Car : Vehicle{
    // Properties specific to cars
    public int SeatCapacity;

    // Method to display car information
    public override void DisplayInfo(){
        // Calling the base class method
        base.DisplayInfo();
        Console.WriteLine("Seats: " + SeatCapacity);
    }
}
