using System;
// Base ATM class
class ATM{
    // Instance variables to store denominations and note counts
    protected int[] denominations;
    protected int[] noteCount;

    // Constructor to initialize denominations and note counts
    public ATM(int[] denoms){
        // Initialize denominations and note counts 
        denominations = denoms;
        noteCount = new int[denoms.Length];
    }


    // Virtual method to dispense notes 
    public virtual void Dispense(int amount){
        int remaining = amount;
        for (int i = 0; i < denominations.Length; i++){         // Traversing the list
            noteCount[i] = remaining / denominations[i];       // Calculate note count
            remaining = remaining % denominations[i];          // Calculate remaining amount
        }

        // Check if exact change is possible 
        if (remaining != 0) {
            // Exact change not possible 
            Console.WriteLine("Exact change not possible");
            Console.WriteLine("Remaining amount: ₹" + remaining);
            return;
        }

        // Display notes
        Console.WriteLine("Amount Dispensed: ₹" + amount);
        // Display note counts 
        for (int i = 0; i < denominations.Length; i++){
            if (noteCount[i] > 0){       // If note count is greater than 0
                Console.WriteLine("₹" + denominations[i] + " x " + noteCount[i]);
            }
        }
    }
}
