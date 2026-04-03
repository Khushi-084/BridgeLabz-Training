using System;
// Main class to demonstrate the scenario
class ATMMain{
    public static void Main(string[] args){

        // Create an instance of the ATM class
        int amount = 880;

        ATM atm;
        // Create an instance of the ATM class
        Console.WriteLine("Scenario A: With ₹500 note");
        atm = new ATMWith500();      // 880 is divisible by 500
        atm.Dispense(amount);        

        Console.WriteLine("------------------");

        // Create an instance of the ATM class
        Console.WriteLine("Scenario B: Without ₹500 note");
        atm = new ATMWithout500();    // 880 is not divisible by 500
        atm.Dispense(amount);

        Console.WriteLine("------------------");
        
        // Create an instance of the ATM class
        Console.WriteLine("Scenario C: Fallback example");
        atm = new ATMLimited();       // 880 is divisible by 200 or 100
        atm.Dispense(350);
    }

        Console.WriteLine("Scenario C: ATM with limited denominations");   // Fallback example
        atmDispenser.Dispense(350);    //    350 is not divisible by 200 or 100
}
