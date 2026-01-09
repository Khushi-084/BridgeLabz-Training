// ATM with limited notes
// Inherited from base class


class ATMLimited : ATM{
    // Constructor to initialize denominations
    public ATMLimited()
        : base(new int[] { 200, 100 }){
    }
}
