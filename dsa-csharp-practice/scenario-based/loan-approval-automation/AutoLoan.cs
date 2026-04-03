using System;

// Represents an auto loan application with specific approval criteria and EMI calculation.
// Inherits from the LoanApplication base class.
class AutoLoan : LoanApplication{
    public AutoLoan(int term, double interestRate, double principal)
        : base("Auto Loan", term, interestRate, principal) { }
    

    // Approves the loan based on applicant's credit score and income.
    public override bool ApproveLoan(Applicant applicant){
        if (applicant.GetCreditScore() >= 600 && applicant.Income >= principal * 0.5){
            SetApprovalStatus(true);
            return true;
        }
        return false;
    }
    
    // Calculates the EMI for the auto loan using a slightly increased interest rate.
    public override double CalculateEMI(){
        double increasedRate = interestRate + 0.5;
        double r = increasedRate / (12 * 100);

        return (principal * r * Math.Pow(1 + r, term)) /
               (Math.Pow(1 + r, term) - 1);
    }
}
