using System;
class Vehicle{
    // Instance variables of the class
    string ownerName;
    string vehicleType;

    // Class variable of the class
    static double registrationFee = 5000;

    // Constructor with parameters
    public Vehicle(string ownerName, string vehicleType){
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
    }

    // Instance method to display vehicle details
    public void DisplayVehicleDetails(){
        Console.WriteLine("\nOwner Name: " + ownerName);
        Console.WriteLine("Vehicle Type: " + vehicleType);
        Console.WriteLine("Registration Fee: " + registrationFee);
    }

    // Class method to update registration fee
    public static void UpdateRegistrationFee(double newFee){
        registrationFee = newFee;
    }
}

class VehicleManagement{
    public static void Main(string[] args){
        // Creating two vehicle objects
        Vehicle v1 = new Vehicle("Rahul", "Car");
        Vehicle v2 = new Vehicle("Anita", "Bike");
        
        // Displaying vehicle details
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();

        // Update registration fee
        Vehicle.UpdateRegistrationFee(6500);
        
        // Displaying vehicle details after updating
        Console.WriteLine("\nAfter Updating Registration Fee:");
        v1.DisplayVehicleDetails();
        v2.DisplayVehicleDetails();
    }
}
