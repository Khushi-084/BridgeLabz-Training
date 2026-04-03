// Electronics class
// Inherits from Product
// Implements ITaxable interface
public class Electronics : Product, ITaxable{
    public Electronics(string name, double price) : base(name, price) { }
    
    // Implement CalculateDiscount method from Product 
    public override double CalculateDiscount(){
        return price * 0.10;
    }
    
    // Implement CalculateTax method from ITaxable 
    public double CalculateTax(){
        return price * 0.18;
    }
}
