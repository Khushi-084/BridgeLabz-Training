using System;
//SchoolTest class to test the Teacher class
class SchoolTest{
    public static void Main(string[] args){
        // Creating a teacher
        Teacher t = new Teacher{
            Name = "Mrs. Sharma",
            Age = 40,
            Subject = "Maths"
        };
        
        // Displaying the teacher with the subject he teaches
        Console.WriteLine($"Teacher: {t.Name}, Subject: {t.Subject}");
    }
}
