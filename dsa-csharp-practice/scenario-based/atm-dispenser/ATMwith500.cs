// ATM with ₹500 note
// Inherited from base class
class ATMWith500 : ATM{
    // Constructor to initialize denominations
    public ATMWith500()
        : base(new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 })
    {
    }
}
