using System;
public class AccountDatabase{
    // Array to store accounts
    public BankAccount[] accounts;
    public int count;
    private int nextAccountNumber;
    

    // Constructor to initialize database
    public AccountDatabase(int size){
        accounts = new BankAccount[size];
        count = 0;
        nextAccountNumber = 101; // Start account numbers from 101
    }


    // Method to Add account to database
    public BankAccount AddAccount(string name, string password, double initialBalance){
        if (count < accounts.Length){
            BankAccount newAccount = new BankAccount(
                nextAccountNumber,
                name,
                password,
                initialBalance
            );
            accounts[count] = newAccount;
            count++;
            nextAccountNumber++;
            return newAccount;
        }
        else{
            Console.WriteLine("Database full! Cannot add more accounts.");
            return null;
        }
    }


    // method to Find account by account number
    public BankAccount FindAccount(int accNum){
        for (int i = 0; i < count; i++){
            if (accounts[i].AccountNumber == accNum){
                return accounts[i];
            }
        }
        return null;
    }
}
