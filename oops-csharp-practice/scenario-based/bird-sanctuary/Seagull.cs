using System;
// Seagull class
// Inheritance from Bird
// Implements IFlyable, ISwimmable
public class Seagull : Bird, IFlyable, ISwimmable{
    // Constructor to initialize seagull
    public Seagull(string name) : base(name, "Seagull") { }

    // Method to fly
    public void Fly(){
        System.Console.WriteLine("Seagull is flying.");
    }
   
    // Method to swim
    public void Swim(){
        System.Console.WriteLine("Seagull is swimming.");
    }
}
