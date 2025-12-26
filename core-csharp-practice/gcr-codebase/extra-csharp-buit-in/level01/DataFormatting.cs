using System;
class DateFormatting{
    public static void Main(string[] args){
        // getting today's date
        DateTime today = DateTime.Now;

        // output
        Console.WriteLine("dd/MM/yyyy : " + today.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd : " + today.ToString("yyyy-MM-dd"));
        Console.WriteLine("EEE, MMM dd, yyyy : " + today.ToString("ddd, MMM dd, yyyy"));
    }
}
