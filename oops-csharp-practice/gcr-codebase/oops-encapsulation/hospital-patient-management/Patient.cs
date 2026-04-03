// Abstract class Patient to calculate total bill
public abstract class Patient{
    protected string name;
    
    // Parameterized constructor to initialize Patient details
    protected Patient(string name){
        this.name = name;
    }
    
    // Abstract method to calculate total bill
    public abstract double CalculateBill();
}
