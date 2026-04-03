using System;

class Program{
    public static void Main(string[] args){
        CallLogManager manager = new CallLogManager(5);


        // Adding call logs to the manager
        manager.AddCallLog(new CallLog(
            new PhoneNumber("9876543210"),
            new Message("Network issue reported"),
            new CallTimeStamp(DateTime.Now.AddHours(-3))
        ));

        manager.AddCallLog(new CallLog(
            new PhoneNumber("9123456789"),
            new Message("Billing related query"),
            new CallTimeStamp(DateTime.Now.AddHours(-2))
        ));

        manager.AddCallLog(new CallLog(
            new PhoneNumber("9000000000"),
            new Message("Internet not working"),
            new CallTimeStamp(DateTime.Now)
        ));
        
        // Displaying call logs in the manager  
        Console.WriteLine("\n Search by keyword 'Internet':");
        CallLog[] keywordResults = manager.SearchByKeyword("Internet");
        foreach (CallLog log in keywordResults){
            log.Display();
        }
        // Filtering call logs by time 
        Console.WriteLine("\n Filter logs from last 2 hours:");
        CallLog[] timeResults = manager.FilterByTime(
            DateTime.Now.AddHours(-2),
            DateTime.Now
        );
        
        // Displaying filtered call logs 
        foreach (CallLog log in timeResults){
            log.Display();
        }
    }
}
