using System;
// EmployeeTest class to test the Employee class
class EmployeeTest{
    public static void Main(string[] args){
        // Creating objects of the Manager, Developer, and Intern classes
        Manager manager = new Manager{
            Name = "Rahul",
            Id = 101,
            Salary = 80000,
            TeamSize = 10
        };

        Developer developer = new Developer{
            Name = "Sneha",
            Id = 102,
            Salary = 65000,
            ProgrammingLanguage = "C#"
        };

        Intern intern = new Intern{
            Name = "Aman",
            Id = 103,
            Salary = 15000,
            InternshipDuration = "6 Months"
        };
         
        // Displaying employee details
        Console.WriteLine("=== Manager Details ===");
        manager.DisplayDetails();

        Console.WriteLine("\n=== Developer Details ===");
        developer.DisplayDetails();

        Console.WriteLine("\n=== Intern Details ===");
        intern.DisplayDetails();
    }
}
