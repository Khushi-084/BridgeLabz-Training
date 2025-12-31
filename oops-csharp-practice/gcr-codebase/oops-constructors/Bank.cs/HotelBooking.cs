using System;
class Hotel{
    // Attributes of the class
    public string GuestName;
    public string RoomType;
    public int Nights;

    // Default constructor
    public Hotel(){
        GuestName = "Unknown";
        RoomType = "Standard";
        Nights = 1;
    }

    // Parameterized constructor
    public Hotel(string guestName, string roomType, int nights){
        this.GuestName = guestName;
        this.RoomType = roomType;
        this.Nights = nights;
    }

    // Copy constructor 
    public Hotel(Hotel booking){
        this.GuestName = booking.GuestName;
        this.RoomType = booking.RoomType;
        this.Nights = booking.Nights;
    }
    
    // Method to display booking details
    public void DisplayBooking(){
        Console.WriteLine("\n--- Hotel Booking Details ---");
        Console.WriteLine("Guest Name: " + GuestName);
        Console.WriteLine("Room Type: " + RoomType);
        Console.WriteLine("Nights: " + Nights);
    }
}

class HotelBooking{
    public static void Main(string[] args){
        // Default booking
        Hotel b1 = new Hotel();
        // Displaying default booking
        b1.DisplayBooking();

        // User input booking
        Console.Write("\nEnter Guest Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Room Type: ");
        string room = Console.ReadLine();
        Console.Write("Enter Nights: ");
        int nights = int.Parse(Console.ReadLine());
        
        // Parameterized booking
        Hotel b2 = new Hotel(name, room, nights);
        // Displaying parameterized booking
        b2.DisplayBooking();

        // Copy booking
        Hotel b3 = new Hotel(b2);
        // Displaying copy booking
        b3.DisplayBooking();
    }
}
