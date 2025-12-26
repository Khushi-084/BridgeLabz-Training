using System;
class TimeZones{
    public static void Main(string[] args) {
        // Get the current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;

        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");


       // Display the time in different time zones
        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime, gmt));
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, ist));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, pst));
    }
}
