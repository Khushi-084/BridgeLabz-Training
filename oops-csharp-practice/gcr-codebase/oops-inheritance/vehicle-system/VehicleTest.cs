using System;
//VehicleTest class to test the Vehicle class
class VehicleTest{
    public static void Main(string[] args){
        // Creating an array of vehicles
        Vehicle[] vehicles ={
            new Car(),
            new Truck(),
            new Motorcycle()
        };
        // Displaying the information of each vehicle
        foreach (Vehicle v in vehicles){
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}
