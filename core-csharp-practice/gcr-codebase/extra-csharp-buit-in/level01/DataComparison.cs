using System;
class DateComparison{
    public static void Main(string[] args){
        // taking input
        Console.WriteLine("Enter first date (yyyy-MM-dd):");
        DateTime date1 = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter second date (yyyy-MM-dd):");
        DateTime date2 = DateTime.Parse(Console.ReadLine());

        // comparing
        int result = DateTime.Compare(date1, date2);

        // output
        if (result < 0)
            Console.WriteLine("First date is BEFORE second date");
        else if (result > 0)
            Console.WriteLine("First date is AFTER second date");
        else
            Console.WriteLine("Both dates are SAME");
    }
}
