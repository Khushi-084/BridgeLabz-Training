using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.HospitalManagement
{
    //inherits Patient and implements IPayable
    internal class OutPatient : Patient
    {
        // OutPatient class
            public double ConsultationFee { get; set; }

            public override double GetBill()
            {
                return ConsultationFee;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"OutPatient ID: {PatientId}, Name: {Name}, Age: {Age}, Consultation Fee: {ConsultationFee}, Total Bill: {GetBill()}");
            }
        }
    }

