class Program{
    public static void Main(string [] args){
        // Creating three vehicle objects
        Vehicle v1 = new Car(2000);
        Vehicle v2 = new Bike(500);
        Vehicle v3 = new Truck(3000);
        
        // Displaying vehicle details
        System.Console.WriteLine(v1.CalculateRentalCost(3));
        System.Console.WriteLine(v2.CalculateRentalCost(3));
        System.Console.WriteLine(v3.CalculateRentalCost(3));
    }
}
