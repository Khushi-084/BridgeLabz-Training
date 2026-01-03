using System;
// VehicleHybridTest class to test the PetrolVehicle and ElectricVehicle classes
class VehicleHybridTest{
    public static void Main(string[] args){
        // Creating objects of the PetrolVehicle and ElectricVehicle classes
        PetrolVehicle pv = new PetrolVehicle();
        ElectricVehicle ev = new ElectricVehicle();
        
        // Refueling and charging the vehicles
        pv.Refuel();
        ev.Charge();
    }
}
