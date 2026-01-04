// Waiter class
// inherits from Person
// implements Worker
class Waiter : Person, Worker{
    public void PerformDuties(){
        Console.WriteLine("Waiter serves food");
    }
}
