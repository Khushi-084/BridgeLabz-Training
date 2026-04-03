// OutPatient inherits Patient
public class OutPatient : Patient{
    public OutPatient(string name) : base(name) { }
    
    // Method to calculate total bill amount
    public override double CalculateBill() {
        return 500;
    }
}
