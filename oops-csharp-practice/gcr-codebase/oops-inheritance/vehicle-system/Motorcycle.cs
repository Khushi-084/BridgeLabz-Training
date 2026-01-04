class Motorcycle : Vehicle{
    // Field to store whether the motorcycle has a sidecar
    public bool HasSidecar;
    
    // Method to display motorcycle information
    public override void DisplayInfo(){
        // Calling the base class method
        base.DisplayInfo();
        Console.WriteLine("Sidecar: " + HasSidecar);
    }
}
