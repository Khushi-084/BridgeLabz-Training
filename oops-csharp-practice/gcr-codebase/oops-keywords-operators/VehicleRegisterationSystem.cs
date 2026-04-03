using System;

class Vehicle{
    // Static field to store registration fee
    public static double RegistrationFee = 2000;
    
    // Instance fields to store vehicle details
    public string OwnerName;
    public string VehicleType;
    public readonly string RegistrationNumber;

    // Constructor with parameters
    public Vehicle(string ownerName, string vehicleType, string regNo){
        this.OwnerName = ownerName;        // this represents the current object
        this.VehicleType = vehicleType;
        this.RegistrationNumber = regNo;
    }
    
    // Static method to update registration fee
    public static void UpdateRegistrationFee(double fee){
        RegistrationFee = fee;
    }
    
    // Instance method to display vehicle details
    public void DisplayDetails(object obj){
        // Checking if the object is of type Vehicle
        if (obj is Vehicle){
            // Displaying vehicle details
            Console.WriteLine("\n--- Vehicle Details ---");
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration No: " + RegistrationNumber);
            Console.WriteLine("Fee: " + RegistrationFee);
        }
    }
}

class VehicleRegisterationSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Owner Name: ");
        string owner = Console.ReadLine();

        Console.Write("Enter Vehicle Type: ");
        string type = Console.ReadLine();

        Console.Write("Enter Registration Number: ");
        string reg = Console.ReadLine();
        
        // Creating an object of the Vehicle class
        Vehicle.UpdateRegistrationFee(2500);

        // Displaying vehicle details
        Vehicle vehicle = new Vehicle(owner, type, reg);
        vehicle.DisplayDetails(vehicle);
    }
}
