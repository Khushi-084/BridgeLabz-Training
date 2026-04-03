class Employee{
    // Attributes of the Employee class
    public string Name;
    public int Id;
    public double Salary;
    
    // Method to display employee details
    public virtual void DisplayDetails(){
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}
