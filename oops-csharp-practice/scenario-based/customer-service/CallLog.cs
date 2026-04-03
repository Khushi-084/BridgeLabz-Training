public class CallLog{
    // Properties of CallLog class
    private PhoneNumber phoneNumber;
    private Message message;
    private CallTimeStamp timeStamp;
    

    // Getters and Setters
    public PhoneNumber PhoneNumber{
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    
    public Message Message{
        get { return message; }
        set { message = value; }
    }

    public CallTimeStamp TimeStamp{
        get { return timeStamp; }
        set { timeStamp = value; }
    }
    
    // Constructor of CallLog class 
    public CallLog(PhoneNumber phoneNumber, Message message, CallTimeStamp timeStamp){
        this.phoneNumber = phoneNumber;
        this.message = message;
        this.timeStamp = timeStamp;
    }
    
    // Method to display call log details
    public void Display(){
        System.Console.WriteLine(
            "Phone: " + phoneNumber.Number +
            ", Message: " + message.Text +
            ", Time: " + timeStamp.Time
        );
    }
}
