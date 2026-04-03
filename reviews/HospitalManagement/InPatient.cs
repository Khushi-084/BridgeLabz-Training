using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.HospitalManagement
{
    // InPatient inherits Patient + implements IPayable
    internal class InPatient : Patient
    {
        public int NumberOfDays { get; set; }
        public double DailyCharge { get; set; }

        public override double GetBill()
        {
            return NumberOfDays * DailyCharge;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"InPatient ID: {PatientId}, Name: {Name}, Age: {Age}, Days: {NumberOfDays}, Daily Charge: {DailyCharge}, Total Bill: {GetBill()}");
        }
    }
}