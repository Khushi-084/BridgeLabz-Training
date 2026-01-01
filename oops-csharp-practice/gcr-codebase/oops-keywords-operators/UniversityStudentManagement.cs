using System;
class Student{
    // Static field of the class
    public static string UniversityName = "XYZ University";
    private static int totalStudents = 0;
    
    // Instance fields of the class
    public string Name;
    public string Grade;
    public readonly int RollNumber;
    
    // Constructor with parameters
    public Student(string name, int rollNumber, string grade){
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalStudents++;
    }
    
    // Static method to display total students
    public static void DisplayTotalStudents(){
        Console.WriteLine("Total Students: " + totalStudents);
    }
    
    // Method to display student details
    public void DisplayDetails(object obj){
        //  Checking if the object is of type Student
        if (obj is Student){
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine("University: " + UniversityName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Roll No: " + RollNumber);
            Console.WriteLine("Grade: " + Grade);
        }
    }
}

class UniversityStudentSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        int roll = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Grade: ");
        string grade = Console.ReadLine();
        
        // Creating an object of the Student class
        Student student = new Student(name, roll, grade);
        
        // Displaying student details
        student.DisplayDetails(student);
        Student.DisplayTotalStudents();
    }
}
