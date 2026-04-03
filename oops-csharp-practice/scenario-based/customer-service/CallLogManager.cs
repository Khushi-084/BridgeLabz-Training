using System;

// CallLogManager class   
public class CallLogManager{
    private CallLog[] logs;
    private int count;
    
    // Constructor to initialize the call log manager
    public CallLogManager(int size){
        logs = new CallLog[size];
        count = 0;
    }
    

    // Method to add a call log 
    public void AddCallLog(CallLog log){
        if (count < logs.Length){
            logs[count] = log;
            count++;
        } else{
            Console.WriteLine("Call log storage is full.");
        }
    }
    
    // Method to search call logs by keyword 
    public CallLog[] SearchByKeyword(string keyword){
        CallLog[] result = new CallLog[count];
        int index = 0;
        
        // Search for logs containing the keyword
        for (int i = 0; i < count; i++){
            if (logs[i].Message.Text.Contains(keyword)){
                result[index] = logs[i];
                index++;
            }
        }

        return TrimArray(result, index);
    }
    
    // Method to filter call logs by time 
    public CallLog[] FilterByTime(DateTime start, DateTime end){
        CallLog[] result = new CallLog[count];
        int index = 0;
        // Filter logs within the specified time range
        for (int i = 0; i < count; i++){
            DateTime logTime = logs[i].TimeStamp.Time;

            if (logTime >= start && logTime <= end){
                result[index] = logs[i];
                index++;
            }
        }

        return TrimArray(result, index);
    }
    
    // Method to trim the result array  
    private CallLog[] TrimArray(CallLog[] array, int size){
        CallLog[] trimmed = new CallLog[size];

        for (int i = 0; i < size; i++){
            trimmed[i] = array[i];
        }

        return trimmed;
    }
}
