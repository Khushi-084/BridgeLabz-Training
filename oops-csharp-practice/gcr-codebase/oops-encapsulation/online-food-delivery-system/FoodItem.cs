// Abstract class FoodItem
public abstract class FoodItem{
    // Properties of a food item
    protected double price;
    protected int quantity;
    
    // Constructor to initialize food item details
    protected FoodItem(double price, int quantity){
        this.price = price;
        this.quantity = quantity;
    }
    
    // Abstract method to calculate total price
    public abstract double CalculateTotalPrice();
}
