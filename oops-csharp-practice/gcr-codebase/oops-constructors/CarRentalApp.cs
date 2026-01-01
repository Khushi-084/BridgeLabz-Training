using System;

class CarRental{
    // Attributes of the CarRental class
    public string CustomerName;
    public string CarModel;
    public int RentalDays;
    public double TotalCost;

    private const double CostPerDay = 1500; // Fixed cost per day

    // Parameterized constructor
    public CarRental(string customerName, string carModel, int rentalDays){
        this.CustomerName = customerName;
        this.CarModel = carModel;
        this.RentalDays = rentalDays;
        this.TotalCost = rentalDays * CostPerDay;
    }
    
    // Method to display rental details
    public void DisplayRentalDetails(){
        Console.WriteLine("\n--- Car Rental Details ---");
        Console.WriteLine($"Customer: {CustomerName}");
        Console.WriteLine($"Car Model: {CarModel}");
        Console.WriteLine($"Rental Days: {RentalDays}");
        Console.WriteLine($"Total Cost: {TotalCost}");
    }
}

class CarRentalApp{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Car Model: ");
        string car = Console.ReadLine();

        Console.Write("Enter Number of Rental Days: ");
        int days = int.Parse(Console.ReadLine());

        // Creating an object of the CarRental class
        CarRental rental = new CarRental(name, car, days);
        // Displaying rental details
        rental.DisplayRentalDetails();
    }
}
