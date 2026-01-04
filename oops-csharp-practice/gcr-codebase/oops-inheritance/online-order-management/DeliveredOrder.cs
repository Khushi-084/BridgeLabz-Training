// Class to represent a delivered order
// Inherits from ShippedOrder
class DeliveredOrder : ShippedOrder{
    // Delivery date of the order
    public string DeliveryDate;
    
    // Method to get the order status
    public string GetOrderStatus(){
        return $"Order delivered on {DeliveryDate}";
    }
}
