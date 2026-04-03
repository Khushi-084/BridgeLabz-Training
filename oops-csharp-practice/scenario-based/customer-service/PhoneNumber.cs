using System;
// PhoneNumber class 
public class PhoneNumber{
    private string number;

    public string Number{
        get { return number; }
        set { number = value; }
    }
    
    // Constructor to initialize phone number 
    public PhoneNumber(string number){
        this.number = number;
    }
}
