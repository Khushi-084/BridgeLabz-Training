// ATM without ₹500 note
// Inherited from base class

class ATMWithout500 : ATM{
    // Constructor to initialize denominations
    
    public ATMWithout500()
        : base(new int[] { 200, 100, 50, 20, 10, 5, 2, 1 })
    {
    }
}
