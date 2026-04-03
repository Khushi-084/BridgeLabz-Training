using System;
public class BankAccount{
    // attributes of a bank account
    public int AccountNumber;
    public string Name;
    private string Password;
    private double Balance;


    // Constructor to initialize attributes
    public BankAccount(int accNum, string name, string password, double initialBalance){
        AccountNumber = accNum;
        Name = name;
        Password = password;
        Balance = initialBalance;
    }


    // method to verify password
    public bool VerifyPassword(string pass){
        return Password == pass;
    }


    // method to check balance 
    public void CheckBalance(){
        Console.WriteLine("Current balance: " + Balance);
    }


    // method to deposit amount
    public void Deposit(double amount){
        if (amount > 0){
            Balance += amount;
            Console.WriteLine("Amount deposited: " + amount);
        }
        else{
            Console.WriteLine("Invalid deposit amount!");
        }
    }


 // method to show account info
    public void ShowAccountInfo(){
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Balance: " + Balance);
    }


    // method to withdraw amount
    public void Withdraw(double amount){
        if (amount <= Balance && amount > 0){
            Balance -= amount;
            Console.WriteLine("Amount withdrawn: " + amount);
        }
        else{
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }  
}
