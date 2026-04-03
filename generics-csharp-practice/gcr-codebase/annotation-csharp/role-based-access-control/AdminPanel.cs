using System;

[RoleAllowed("ADMIN")]
public class AdminPanel{
    public static void DeleteUser() {
        Console.WriteLine("User deleted successfully");
    }
}
