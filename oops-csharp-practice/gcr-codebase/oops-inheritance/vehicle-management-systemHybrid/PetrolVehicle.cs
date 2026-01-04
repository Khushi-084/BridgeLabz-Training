// PetrolVehicle.cs
// Inherits from the Vehicle class
// Implements the Refuelable interface
class PetrolVehicle : Vehicle, Refuelable{
    // Method to refuel the vehicle
    public void Refuel(){
        Console.WriteLine("Refueling petrol vehicle");
    }
}
