class EmployeeMain
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Employee Wage Management");
        EmployeeMenu menu = new EmployeeMenu();
        menu.ShowMenu();
    }
}