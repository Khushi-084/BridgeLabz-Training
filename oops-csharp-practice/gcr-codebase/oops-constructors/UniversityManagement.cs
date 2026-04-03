using System;
class Student{
    // Attributes of the class
    public int rollNumber;      // public
    protected string name;      // protected
    private double CGPA;        // private
    
    // Constructor with parameters 
    public Student(int rollNumber, string name, double cgpa){
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = cgpa;
    }

    // Public method to access private CGPA
    public double GetCGPA(){
        return CGPA;
    }

    // Public method to modify private CGPA
    public void SetCGPA(double cgpa){
        CGPA = cgpa;
    }
}

// Subclass of Student
class PostgraduateStudent : Student{
    public PostgraduateStudent(int rollNumber, string name, double cgpa)
        : base(rollNumber, name, cgpa) { }
    
    // Method to display student details
    public void Display(){
        Console.WriteLine("\nRoll Number: " + rollNumber); // public
        Console.WriteLine("Name: " + name);               // protected
        Console.WriteLine("CGPA: " + GetCGPA());           // private via method
    }
}

class UniversityManagement{
    public static void Main(string[] args){
        // Creating a postgraduate student
        PostgraduateStudent pg = new PostgraduateStudent(101, "Khushi", 8.9);
        // Displaying student details
        pg.Display();
        
        // Updating CGPA
        pg.SetCGPA(9.2);
        // Displaying updated CGPA
        Console.WriteLine("Updated CGPA: " + pg.GetCGPA());
    }
}

