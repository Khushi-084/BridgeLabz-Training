using System;
class Course{
    // Instance variables of the class
    string courseName;
    int duration;   // in days
    double fee;

    // Class variable of the class
    static string instituteName = "ABC Institute";

    // Constructor with parameters
    public Course(string courseName, int duration, double fee){
        this.courseName = courseName;       // this represents the current object
        this.duration = duration;
        this.fee = fee;
    }

    // Instance method to display course details
    public void DisplayCourseDetails(){
        Console.WriteLine("\nCourse Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " days");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute: " + instituteName);
    }

    // Class method to update the institute name
    public static void UpdateInstituteName(string newName){
        instituteName = newName;
    }
}

class OnlineCourseManagement{
    public static void Main(string[] args){
        // Creating two course objects
        Course c1 = new Course("C# Programming", 30, 6000);
        Course c2 = new Course("Java Programming", 25, 5500);
        
        // Displaying course details
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();

        // Update institute name
        Course.UpdateInstituteName("XYZ Academy");

        Console.WriteLine("\nAfter Updating Institute Name:");
        // Displaying course details
        c1.DisplayCourseDetails();
        c2.DisplayCourseDetails();
    }
}
