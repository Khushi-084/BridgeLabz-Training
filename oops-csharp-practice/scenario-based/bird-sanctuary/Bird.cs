using System;
// Bird class 
public class Bird{
    //  Private fields 
    private string name;
    private string species;
    
    public string Name{
        get { return name; }
        set { name = value; }
    }

    public string Species{
        get { return species; }
        set { species = value; }
    }
    
    // Constructor to initialize bird 
    public Bird(string name, string species){
        Name = name;
        Species = species;
    }
    
    // Virtual method to display bird information
    public virtual void DisplayInfo(){
        System.Console.WriteLine("Name: " + Name + ", Species: " + Species);
    }
}
