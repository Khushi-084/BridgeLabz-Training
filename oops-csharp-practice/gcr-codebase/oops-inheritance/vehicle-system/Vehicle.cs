class Vehicle{
    // Properties
    public int MaxSpeed;
    public string FuelType;
    
    // Method to display vehicle information
    public virtual void DisplayInfo(){
        Console.WriteLine($"Speed: {MaxSpeed}, Fuel: {FuelType}");
    }
}
