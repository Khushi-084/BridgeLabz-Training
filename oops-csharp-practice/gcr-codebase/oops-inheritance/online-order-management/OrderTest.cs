using System;
// OrderTest class to test the DeliveredOrder class
class OrderTest{
    public static void Main(string[] args){

        DeliveredOrder order = new DeliveredOrder{
            // Calling the base class constructor
            OrderId = 101,
            OrderDate = "01-Jan-2026",
            TrackingNumber = "TRK123",
            DeliveryDate = "05-Jan-2026"
        };

        // Calling the derived class method
        Console.WriteLine(order.GetOrderStatus());
    }
}
