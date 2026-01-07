// FullTimeEmployee class inherits Employee class
public class FullTimeEmployee : Employee, IDepartment{
    private string department;
    
    // Constructor with parameters to initialize attributes
    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name, salary) { }
    

    // Method to calculate salary 
    public override double CalculateSalary(){
        return baseSalary;
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
