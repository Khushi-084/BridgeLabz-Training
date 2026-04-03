using System;

// Represents a personal loan application with specific approval criteria and EMI calculation.
// Inherits from the LoanApplication base class.
class PersonalLoan : LoanApplication{
    // Initializes the personal loan with given term, interest rate, and principal amount.
    public PersonalLoan(int term, double interestRate, double principal)
        : base("Personal Loan", term, interestRate, principal) { }


    // Approves the loan based on applicant's credit score and income.
    public override bool ApproveLoan(Applicant applicant){
        if (applicant.GetCreditScore() >= 650 && applicant.Income >= principal * 0.4){
            SetApprovalStatus(true);
            return true;
        }
        return false;
    }
 

    // Calculates the EMI for the personal loan using the standard formula.
    public override double CalculateEMI(){
        double r = interestRate / (12 * 100);
        return (principal * r * Math.Pow(1 + r, term)) / (Math.Pow(1 + r, term) - 1);
    }
}
