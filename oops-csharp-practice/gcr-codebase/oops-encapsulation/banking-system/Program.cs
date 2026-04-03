using System;

class Program{
    public static void Main(string[] args){
        // Creating two bank accounts 
        BankAccount acc1 = new SavingsAccount(100000);
        BankAccount acc2 = new CurrentAccount(200000);
       
       // Calculating interest for both accounts
        System.Console.WriteLine(acc1.CalculateInterest());
        System.Console.WriteLine(acc2.CalculateInterest());
    }
}
