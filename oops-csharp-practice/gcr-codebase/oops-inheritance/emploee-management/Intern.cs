class Intern : Employee{
    // Properties for internship duration
    public string InternshipDuration;

    // Method to display intern details
    public override void DisplayDetails(){
        // Calling the base class method
        base.DisplayDetails();
        Console.WriteLine("Duration: " + InternshipDuration);
    }
}
