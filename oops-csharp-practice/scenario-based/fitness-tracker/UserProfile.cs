// User Profile class to store user details
class UserProfile{
    // Fields to store user details
    private string userName;
    private int age;

    // Constructor to initialize user details
    public UserProfile(string userName, int age){
        // Constructor to initialize user details
        this.userName = userName;
        this.age = age;
    }
    
    // Method to display user details 
    public void DisplayUser(){
        Console.WriteLine($"User Name: {userName}");
        Console.WriteLine($"Age: {age}");
    }
}
