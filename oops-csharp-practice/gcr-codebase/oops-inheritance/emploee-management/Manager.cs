class Manager : Employee{
    // Properties for team size
    public int TeamSize;
    
    // Method to display manager details
    public override void DisplayDetails(){
        // Calling the base class method
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}
