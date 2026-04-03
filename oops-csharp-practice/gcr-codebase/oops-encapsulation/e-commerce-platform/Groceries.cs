// Implement CalculateDiscount method from Product
public class Groceries : Product{
    public Groceries(string name, double price) : base(name, price) { }

    // Implement CalculateDiscount method from Product
    public override double CalculateDiscount(){
        return price * 0.05;
    }
}
