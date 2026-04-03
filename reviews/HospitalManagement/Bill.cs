using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.HospitalManagement
{
    internal class Bill
    {
        // Bill class
         private Patient patient;

            public Bill(Patient patient)
            {
                this.patient = patient;
            }

            public void DisplayBill()
            {
                Console.WriteLine($"Bill for {patient.Name}: {patient.GetBill()}");
            }
        }
    }


