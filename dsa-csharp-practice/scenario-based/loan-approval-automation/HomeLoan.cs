using System;

// Represents a home loan application with specific approval criteria and EMI calculation.
// Inherits from the LoanApplication base class.
class HomeLoan : LoanApplication{
    // Initializes the home loan with given term, interest rate, and principal amount.
    public HomeLoan(int term, double interestRate, double principal)
        : base("Home Loan", term, interestRate, principal) { }
    

    // Approves the loan based on applicant's credit score and income.
    public override bool ApproveLoan(Applicant applicant){
        if (applicant.GetCreditScore() >= 700 && applicant.Income >= principal * 0.3){
            SetApprovalStatus(true);
            return true;
        }
        return false;
    }
    
    // Calculates the EMI for the home loan using a slightly reduced interest rate.
    public override double CalculateEMI(){
        double reducedRate = interestRate - 0.5;
        double r = reducedRate / (12 * 100);

        return (principal * r * Math.Pow(1 + r, term)) /
               (Math.Pow(1 + r, term) - 1);
    }
}
