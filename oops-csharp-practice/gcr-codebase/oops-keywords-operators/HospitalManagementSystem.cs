using System;
class Patient{
    // Static field to store the name of the hospital
    public static string HospitalName = "City Hospital";
    private static int totalPatients = 0;
    
    // Instance fields to store patient details
    public string Name;
    public int Age;
    public string Ailment;
    public readonly int PatientID;
    
    // Parameterized constructor
    public Patient(string name, int age, string ailment, int patientID){
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientID;
        totalPatients++;
    }
    
    // Static method to display total patients
    public static void GetTotalPatients(){
        Console.WriteLine("Total Patients: " + totalPatients);
    }
    
    // Method to display patient details
    public void DisplayDetails(object obj){
        // Check if the object is of type Patient
        if (obj is Patient){
            Console.WriteLine("\n--- Patient Details ---");
            Console.WriteLine("Hospital: " + HospitalName);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Ailment: " + Ailment);
            Console.WriteLine("Patient ID: " + PatientID);
        }
    }
}

class HospitalManagementSystem{
    public static void Main(string[] args){
        // Taking input from the user
        Console.Write("Enter Patient Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Ailment: ");
        string ailment = Console.ReadLine();

        Console.Write("Enter Patient ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        
        // Creating an object of the Patient class
        Patient patient = new Patient(name, age, ailment, id);
        
        // Displaying patient details
        patient.DisplayDetails(patient);
        Patient.GetTotalPatients();
    }
}
