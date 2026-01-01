using System;
class Circle{
    // Attributes of the class
    public double Radius;

    // Default constructor
    public Circle() : this(1.0)       
    {
        // Calls parameterized constructor with default radius 1.0
    }

    // Parameterized constructor
    public Circle(double radius){
        this.Radius = radius;
    }
     
     // Method to calculate area of circle
    public double CalculateArea(){
        return Math.PI * Radius * Radius;
    }
    
    // Method to calculate circumference of circle
    public double CalculateCircumference(){
        return 2 * Math.PI * Radius;
    }
    
    // Method to display circle details
    public void DisplayDetails(){
        Console.WriteLine("\n--- Circle Details ---");
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

class CircleClass{
    public static void Main(string[] args){
        Circle defaultCircle = new Circle(); // default radius
        // Displaying default circle details
        defaultCircle.DisplayDetails();
        // Taking input from the user
        Console.Write("\nEnter radius for a new circle: ");
        // Creating an object of the Circle class
        double r = double.Parse(Console.ReadLine());
        // Displaying circle details
        Circle userCircle = new Circle(r);
        // Displaying user circle details
        userCircle.DisplayDetails();

    }
}
