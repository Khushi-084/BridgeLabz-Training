using System;
// Subclass of BankAccount implementing ILoanable
// Class SavingsAccount
public class SavingsAccount : BankAccount, ILoanable{
    public SavingsAccount(double balance) : base(balance) { }
    
    // Method to calculate interest 
    public override double CalculateInterest(){
        return balance * 0.04;
    }
    
    // Method to calculate loan eligibility 
    public double CalculateLoanEligibility(){
        return balance * 5;
    }
}
