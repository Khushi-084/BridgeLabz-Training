// PartTimeEmployee class inherits Employee class
public class PartTimeEmployee : Employee, IDepartment{
    private int hoursWorked;
    private double ratePerHour;
    private string department;
    
    // Constructor with parameters to initialize attributes
    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name, 0)
    {
        hoursWorked = hours;
        ratePerHour = rate;
    }
    
    // Method to calculate salary 
    public override double CalculateSalary(){
        return hoursWorked * ratePerHour;
    }
    
    // Method to assign department 
    public void AssignDepartment(string department){
        this.department = department;
    }
    
    // Method to get department details 
    public string GetDepartmentDetails(){
        return department;
    }
}
