using System;

// CallTimeStamp class 
public class CallTimeStamp{
    private DateTime time;
    
    public DateTime Time{
        get { return time; }
        set { time = value; }
    }
    
    // Constructor to initialize time 
    public CallTimeStamp(DateTime time)
    {
        this.time = time;
    }
}
