using System;
// RestaurantTest class to test the Chef and Waiter classes
class RestaurantTest{
    public static void Main(string[] args){
        // Creating workers
        Worker chef = new Chef();
        Worker waiter = new Waiter();
        
        // Performing duties
        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
