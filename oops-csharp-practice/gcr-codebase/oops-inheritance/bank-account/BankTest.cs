using System;
//BankTest class to test the SavingsAccount class
class BankTest{
    public static void Main(string[] args){
        // Creating a savings account
        SavingsAccount sa = new SavingsAccount {
            AccountNumber = 1001,
            Balance = 50000,
            InterestRate = 4.5
        };
        
        // Displaying account details
        Console.WriteLine("Savings Account Balance: " + sa.Balance);
    }
}
