class Thermostat : Device{
    // Properties for Thermostat
    public int TemperatureSetting;
    
    // Method to display thermostat status
    public void DisplayStatus(){
        Console.WriteLine($"Device ID: {DeviceId}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine($"Temperature: {TemperatureSetting}");
    }
}
