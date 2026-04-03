// Clothing class
// Inherits from Product
// Implements ITaxable interface
public class Clothing : Product, ITaxable{
    public Clothing(string name, double price) : base(name, price) { }
    
    // Implement CalculateDiscount method from Product
    public override double CalculateDiscount(){
        return price * 0.20;
    }
    
    // Implement CalculateTax method from ITaxable
    public double CalculateTax(){
        return price * 0.12;
    }
}
