// Represents a loan applicant with relevant financial details.
class Applicant{
    // Attributes of the applicant
    public string Name { get; private set; }
    private int creditScore;
    public double Income { get; private set; }
    public double LoanAmount { get; private set; }

    // Initializes the applicant with provided details.
    public Applicant(string name, int creditScore, double income, double loanAmount){
        Name = name;
        this.creditScore = creditScore;
        Income = income;
        LoanAmount = loanAmount;
    }
    
    // Retrieves the credit score of the applicant
    protected int GetCreditScore(){
        return creditScore;
    }
}
