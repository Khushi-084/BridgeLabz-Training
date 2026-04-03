using System;
using System.Reflection;

class Program{
    public static void Main(string[] args){
        string currentUserRole = "USER"; // change to ADMIN
        var attr = typeof(AdminPanel)
            .GetCustomAttribute<RoleAllowedAttribute>();
        if (attr.Role == currentUserRole){
            new AdminPanel().DeleteUser();
        }
        else{
            Console.WriteLine("Access Denied!");
        }
    }
}
