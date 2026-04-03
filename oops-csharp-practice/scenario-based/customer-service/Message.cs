using System;
// Message class 
public class Message{
    private string text;

    public string Text{
        get { return text; }
        set { text = value; }
    }
    
    // Constructor to initialize message 
    public Message(string text){
        this.text = text;
    }
}
