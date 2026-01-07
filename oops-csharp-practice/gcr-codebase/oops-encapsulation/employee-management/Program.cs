using System;
using System.Collections.Generic;

class Program{
    public static void Main(string[] args){
        List<Employee> employees = new List<Employee>{
            new FullTimeEmployee(1, "Amit", 50000),
            new PartTimeEmployee(2, "Riya", 80, 300)
        };

        foreach (Employee emp in employees){
            emp.DisplayDetails();
        }
    }
}
