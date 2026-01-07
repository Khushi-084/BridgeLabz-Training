// Employee class with abstract method
public abstract class Employee{
    // Private fields to store employee details
    private int employeeId;
    private string name;
    protected double baseSalary;

    public int EmployeeId => employeeId;
    public string Name => name;
    
    // Constructor with parameters
    protected Employee(int id, string name, double baseSalary){
        employeeId = id;
        this.name = name;
        this.baseSalary = baseSalary;
    }
    
    // Abstract method to calculate salary
    public abstract double CalculateSalary();
    
    // Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine($"ID: {employeeId}, Name: {name}, Salary: {CalculateSalary()}");
    }
}
