using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.employee_wages_management
{
    internal class EmployeeMenu
    {
       private IEmployee employeeUtility;
        private Employee employee;
        public EmployeeMenu()
        {
            employeeUtility = new EmployeeUtilityImpl();
            employee = new Employee();
            ShowMenu();
        }
        public void ShowMenu()
        {
            Console.WriteLine("1. Adding an employee"); //UC0
            Console.WriteLine("2. Check Attendance");//UC1
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1: //UC-0 Functionality
                    employee = employeeUtility.AddEmployee(employee);
                    Console.WriteLine("Employee Added Suceessfully");
                    break;
                case 2: //UC-1 Functionality
                    employeeUtility.CheckAttendance();
                    break;
                case 3: //UC - 2,3,4 Functionality
                    int wage = employeeUtility.CalculateDailyWage();
                    Console.WriteLine("Daily Wage: " + wage);
                    break;
                case 4: //UC-5 Implementation
                    employeeUtility.CalculateMonthlyWage(employee);
                    Console.WriteLine(employee);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
