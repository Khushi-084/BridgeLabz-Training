using System;
class DateArithmetic{
    public static void Main(string[] args){
        // taking input
        Console.WriteLine("Enter a date (yyyy-MM-dd):");
        string input = Console.ReadLine();

        // parsing
        DateTime date = DateTime.Parse(input);
        // adding
        date = date.AddDays(7);
        date = date.AddMonths(1);
        date = date.AddYears(2);
        date = date.AddDays(-21); // 3 weeks = 21 days

        // output
        Console.WriteLine("Final Date: " + date.ToString("dd/MM/yyyy"));
    }
}
