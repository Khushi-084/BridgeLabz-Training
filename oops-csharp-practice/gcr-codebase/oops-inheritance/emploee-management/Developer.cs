class Developer : Employee{
    // Additional attribute
    public string ProgrammingLanguage;

    // Method to display developer details
    public override void DisplayDetails(){
        // Calling the base class method
        base.DisplayDetails();
        Console.WriteLine("Language: " + ProgrammingLanguage);
    }
}
