// VegItem class derived from FoodItem
public class VegItem : FoodItem{
    // Constructor to initialize veg item details
    public VegItem(double price, int quantity) : base(price, quantity) { }
    
    // Override CalculateTotalPrice method from FoodItem
    public override double CalculateTotalPrice(){
        return price * quantity;
    }
}
