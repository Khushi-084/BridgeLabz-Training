using System;
// RideHailingApplication
class Program{
    public static void Main(string[] args){
        // Creating three vehicle objects
        Vehicle v1 = new Car(15);
        Vehicle v2 = new Bike(10);
        Vehicle v3 = new Auto(12);
        
        // Displaying vehicle details
        System.Console.WriteLine(v1.CalculateFare(10));
        System.Console.WriteLine(v2.CalculateFare(10));
        System.Console.WriteLine(v3.CalculateFare(10));
    }
}
