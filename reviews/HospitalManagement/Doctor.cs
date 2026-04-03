using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.HospitalManagement
{
    internal class Doctor
    {
        public int DoctorId
        {
            get; set;
        }
        public string DoctorName
        {
            get; set;
        }
        public string Specialization
        {
            get; set;
        }

        // Method to display doctor details
        public void DisplayDoctorInfo()
        {
            Console.WriteLine("Doctor ID: " + DoctorId);
            Console.WriteLine("Doctor Name: " + DoctorName);
            Console.WriteLine("Specialization: " + Specialization);
        }

    }
}
