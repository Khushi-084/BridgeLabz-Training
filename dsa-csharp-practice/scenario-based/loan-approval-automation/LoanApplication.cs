// Represents a generic loan application with common attributes and methods.
// Implements the IApprovable interface for loan approval and EMI calculation.
abstract class LoanApplication : IApprovable{
    // Common attributes for all loan applications
    protected string loanType;
    protected int term;               // in months
    protected double interestRate;
    protected double principal;

    private bool isApproved;
    
    // Initializes the loan application with provided details.
    public LoanApplication(string loanType, int term, double interestRate, double principal){
        this.loanType = loanType;
        this.term = term;
        this.interestRate = interestRate;
        this.principal = principal;
        this.isApproved = false;
    }
    
    // Sets the approval status of the loan application
    protected void SetApprovalStatus(bool status){
        isApproved = status;
    }
    
    // Retrieves the approval status of the loan application
    public bool GetApprovalStatus(){
        return isApproved;
    }
    
    // Abstract methods to be implemented by derived classes
    public abstract bool ApproveLoan(Applicant applicant);
    public abstract double CalculateEMI();
}
