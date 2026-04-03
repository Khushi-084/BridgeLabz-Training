using System;
//  Sparrow class
//  Inheritance from Bird
//  Implements IFlyable
public class Sparrow : Bird, IFlyable{
    public Sparrow(string name) : base(name, "Sparrow") { }
    
    // Method to fly 
    public void Fly(){
        System.Console.WriteLine("Sparrow is flying fast.");
    }
}
