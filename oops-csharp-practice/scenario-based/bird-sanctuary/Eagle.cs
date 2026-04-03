using System;
// Eagle class
// Inheritance from Bird
// Implements IFlyable 
public class Eagle : Bird, IFlyable{
    public Eagle(string name) : base(name, "Eagle") { }
    
    // Method to fly 
    public void Fly(){
        System.Console.WriteLine("Eagle is flying high.");
    }
}
