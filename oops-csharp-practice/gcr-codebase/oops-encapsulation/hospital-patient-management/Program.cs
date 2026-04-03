using System;
class Program{
    public static void Main(string[] args){
        // Creating two patients
        Patient p1 = new InPatient("Rahul", 3);
        Patient p2 = new OutPatient("Anita");
        
        // Displaying total bill
        System.Console.WriteLine(p1.CalculateBill());
        System.Console.WriteLine(p2.CalculateBill());
    }
}
