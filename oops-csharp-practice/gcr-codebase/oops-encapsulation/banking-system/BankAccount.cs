using System;
// Abstract class BankAccount 
public abstract class BankAccount{
    protected double balance;
    
    // Constructor to initialize balance 
    protected BankAccount(double balance){
        this.balance = balance;
    }
    
    // Abstract method to calculate interest
    public abstract double CalculateInterest();
}
