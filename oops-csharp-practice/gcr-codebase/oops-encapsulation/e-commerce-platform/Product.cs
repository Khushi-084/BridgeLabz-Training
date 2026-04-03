// Abstract class Product 
public abstract class Product{
    // Fields 
    protected string name;
    protected double price;
    
    // Constructor with parameters 
    protected Product(string name, double price){
        this.name = name;
        this.price = price;
    }
    
    // Abstract method
    public abstract double CalculateDiscount();
    
    // Method to calculate final price
    public double GetFinalPrice(){
        double tax = this is ITaxable t ? t.CalculateTax() : 0;
        return price + tax - CalculateDiscount();
    }
}
