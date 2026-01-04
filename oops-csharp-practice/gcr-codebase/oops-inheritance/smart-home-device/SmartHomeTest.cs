using System;
// SmartHomeTest class to test the Thermostat class
class SmartHomeTest{
    public static void Main(string[] args){
        // Creating an object of the Thermostat class
        Thermostat t = new Thermostat {
            DeviceId = 1,
            Status = "ON",
            TemperatureSetting = 24
        };
        // Displaying thermostat status
        t.DisplayStatus();
    }
}
