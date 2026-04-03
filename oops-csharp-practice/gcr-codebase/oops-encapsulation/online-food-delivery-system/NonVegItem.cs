// NonVegItem class derived from FoodItem
public class NonVegItem : FoodItem{
    // Constructor to initialize non-veg item details
    public NonVegItem(double price, int quantity) : base(price, quantity) { }
    
    // Override CalculateTotalPrice method from FoodItem
    public override double CalculateTotalPrice(){
        return (price * quantity) + 50;
    }
}
