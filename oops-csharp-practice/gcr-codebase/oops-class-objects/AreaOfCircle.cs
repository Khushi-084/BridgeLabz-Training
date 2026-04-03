using System;
class Circle{
    // Attributes of the Circle class
    double radius;
    
    // Constructor to initialize attributes
    public Circle(double radius){
        this.radius = radius;         // this represents the current object
    }
    
    // Method to calculate area
    public double CalculateArea(){
        return Math.PI * radius * radius;
    }
    
    // Method to calculate circumference
    public double CalculateCircumference(){
        return 2 * Math.PI * radius;
    }
    
    // Method to display circle details
    public void DisplayDetails(){
        Console.WriteLine("\n--- Circle Details ---");
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class Program{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        // Creating an object of the Circle class
        Circle c = new Circle(radius);
        // Displaying circle details
        c.DisplayDetails();
    }
}
