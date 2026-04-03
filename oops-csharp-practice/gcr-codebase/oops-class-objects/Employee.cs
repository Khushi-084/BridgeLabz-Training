using System;
class Employee{
    // Attributes of the Employee
    string name;
    int id;
    double salary;

    // Constructor to initialize attributes
    public Employee(string name, int id, double salary){
        this.name = name;         // this represents the current object
        this.id = id;
        this.salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine("Employee Name: " + name);
        Console.WriteLine("Employee ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Salary: ");
        double salary = double.Parse(Console.ReadLine());
        
        // Creating an object of the Employee class
        Employee emp = new Employee(name, id, salary);
        // Displaying employee details
        emp.DisplayDetails();
    }
}
