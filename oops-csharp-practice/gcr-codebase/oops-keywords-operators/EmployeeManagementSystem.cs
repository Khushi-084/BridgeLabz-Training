using System;

class Employee{
    // Static field and method
    public static string CompanyName = "TechCorp";
    private static int totalEmployees = 0;
    
    // Instance fields 
    public string Name;
    public string Designation;
    public readonly int Id;
    
    // Constructor with parameters
    public Employee(string name, int id, string designation){
        this.Name = name;
        this.Id = id;
        this.Designation = designation;
        totalEmployees++;
    }
    
    // Static method to display total employees
    public static void DisplayTotalEmployees(){
        Console.WriteLine("Total Employees: " + totalEmployees);
    }
    
    // Method to display employee details
    public void DisplayDetails(object obj){
        // Check if the object is of type Employee
        if (obj is Employee){
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Company: " + CompanyName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Designation: " + Designation);
        }
    }
}

class EmployeeManagementSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Designation: ");
        string designation = Console.ReadLine();
        
        // Creating an object of the Employee class
        Employee emp = new Employee(name, id, designation);
        // Displaying employee details
        emp.DisplayDetails(emp);
        Employee.DisplayTotalEmployees();
    }
}
