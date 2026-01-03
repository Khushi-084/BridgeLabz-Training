using System;
// CourseTest class to test the PaidOnlineCourse class
class CourseTest{
    public static void Main(string[] args){
        
        // Creating an object of the PaidOnlineCourse class
        PaidOnlineCourse course = new PaidOnlineCourse {
            CourseName = "C# Mastery",
            Duration = 40,
            Platform = "Udemy",
            IsRecorded = true,
            Fee = 2000,
            Discount = 500
        };
        
        // Displaying course details and fee
        Console.WriteLine($"Course: {course.CourseName}");
        Console.WriteLine($"Fee after discount: {course.Fee - course.Discount}");
    }
}
