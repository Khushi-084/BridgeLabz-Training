using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.employee_wages_managament
{
    internal interface IEmployee
    {
        Employee AddEmployee(Employee employee); //referring to UC-0 Functionality
        void CheckAttendance();//referring to UC1-1 Functionality
        int CalculateDailyWage(); //referring to UC2 ,3,4 Functionality
        void CalculateMonthlyWage(Employee employee); // referring UC5 Functionality
    }
}


