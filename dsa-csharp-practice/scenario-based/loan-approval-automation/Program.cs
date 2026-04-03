using System;

class Program{
    public static void Main(string[] args){
        // Input applicant details
        Console.Write("Enter applicant name: ");
        string name = Console.ReadLine();

        Console.Write("Enter credit score: ");
        int creditScore = int.Parse(Console.ReadLine());

        Console.Write("Enter monthly income: ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Enter loan amount: ");
        double loanAmount = double.Parse(Console.ReadLine());

        Applicant applicant = new Applicant(name, creditScore, income, loanAmount);  // Create applicant instance

        Console.Write("Choose loan type (1-Personal, 2-Home, 3-Auto): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter loan term (months): ");
        int term = int.Parse(Console.ReadLine());

        Console.Write("Enter interest rate: ");
        double rate = double.Parse(Console.ReadLine());

        LoanApplication loan;  // Declare loan application variable
        
        // Instantiate the appropriate loan type based on user choice
        if (choice == 1)
            loan = new PersonalLoan(term, rate, loanAmount);
        else if (choice == 2)
            loan = new HomeLoan(term, rate, loanAmount);
        else
            loan = new AutoLoan(term, rate, loanAmount);

        if (loan.ApproveLoan(applicant))
        {
            Console.WriteLine("\nLoan Approved!");
            Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
        }
        else
        {
            Console.WriteLine("\nLoan Rejected!");
        }
    }
}
