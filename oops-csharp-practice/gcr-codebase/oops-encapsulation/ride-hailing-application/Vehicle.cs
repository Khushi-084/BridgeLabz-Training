// Vehicle class to represent a vehicle
public abstract class Vehicle{
    // Vehicle details 
    protected double rate;
    
    // Constructor to initialize vehicle details
    protected Vehicle(double rate){
        this.rate = rate;
    }
    
    // Abstract method to calculate fare
    public abstract double CalculateFare(double distance);
}
