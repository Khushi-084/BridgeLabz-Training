using System;
// Duck class 
// Inheritance from Bird 
// Implements ISwimmable
public class Duck : Bird, ISwimmable{
    public Duck(string name) : base(name, "Duck") { }

    // Method to swim
    public void Swim(){
        System.Console.WriteLine("Duck is swimming.");
    }
}
