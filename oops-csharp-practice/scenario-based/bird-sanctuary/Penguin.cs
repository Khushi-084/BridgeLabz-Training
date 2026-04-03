using System;
// Penguin class
// Inheritance from Bird
// Implements ISwimmable
public class Penguin : Bird, ISwimmable{
    public Penguin(string name) : base(name, "Penguin") { }
    
    // Method to swim
    public void Swim(){
        System.Console.WriteLine("Penguin is swimming.");
    }
}
