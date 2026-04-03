class Truck : Vehicle{
    // property to store the payload capacity
    public int PayloadCapacity;
    
    // Method to display truck information
    public override void DisplayInfo(){
        // Calling the base class method
        base.DisplayInfo();
        Console.WriteLine("Payload: " + PayloadCapacity);
    }
}
