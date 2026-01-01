using System;

class BankAccount{
    // Static field shared by all accounts
    public static string BankName = "ABC Bank";
    private static int totalAccounts = 0;

    public string AccountHolderName;
    public readonly int AccountNumber;

    // Constructor with parameters
    public BankAccount(string accountHolderName, int accountNumber){
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber;
        totalAccounts++;
    }

    // Static method to display total accounts
    public static void GetTotalAccounts(){
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // Display details using is operator
    public void DisplayDetails(object obj){
        // Check if the object is of type BankAccount
        if (obj is BankAccount){
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Bank Name     : {BankName}");
            Console.WriteLine($"Holder Name   : {AccountHolderName}");
            Console.WriteLine($"Account No    : {AccountNumber}");
        }
    }
}

class BankAccountSystem{
    public static void Main(string[] args){
        // Get user input
        Console.WriteLine("Enter Account Holder Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Account Number:");
        int accNumber = Convert.ToInt32(Console.ReadLine());

        // Create object using user input
        BankAccount account = new BankAccount(name, accNumber);

        // Display details
        account.DisplayDetails(account);

        // Display total accounts
        BankAccount.GetTotalAccounts();
    }
}
