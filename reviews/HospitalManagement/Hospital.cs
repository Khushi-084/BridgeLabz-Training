using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Review.HospitalManagement
{
    // Main class 
    internal class Hospital
    {
        public static void Main()
        {
            Console.Write("Enter number of patients: ");
            int n = int.Parse(Console.ReadLine());

            //Array to store data
            Patient[] patients = new Patient[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter details for patient {i + 1}:");

                Console.Write("Patient ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Type (1 = InPatient, 2 = OutPatient): ");
                int type = int.Parse(Console.ReadLine());

                if (type == 1)
                {
                    Console.Write("Number of Days: ");
                    int days = int.Parse(Console.ReadLine());

                    Console.Write("Daily Charge: ");
                    double charge = double.Parse(Console.ReadLine());

                    patients[i] = new InPatient
                    {
                        PatientId = id,
                        Name = name,
                        Age = age,
                        NumberOfDays = days,
                        DailyCharge = charge
                    };
                }
                else if (type == 2)
                {
                    Console.Write("Consultation Fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    patients[i] = new OutPatient
                    {
                        PatientId = id,
                        Name = name,
                        Age = age,
                        ConsultationFee = fee
                    };
                }
            }

            // bubble sort
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (patients[j].GetBill() > patients[j + 1].GetBill())
                    {
                        Patient temp = patients[j];
                        patients[j] = patients[j + 1];
                        patients[j + 1] = temp;
                    }
                }
            }

            // Display Sorted  
            Console.WriteLine("\nPatients Sorted by Bill Amount:");
            for (int i = 0; i < n; i++)
            {
                patients[i].DisplayInfo();
                Bill bill = new Bill(patients[i]);
                bill.DisplayBill();

            }
        }
    }
}













