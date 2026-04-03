using System;

namespace Training.smart_home_automation
{
    //Fan class inherits Appliance
    internal class Fan : Appliance
    {
        public Fan() : base("Fan") { }
        
        // Overriding (Polymorphism)
        public override void TurnOn()
        {
            Console.WriteLine("Fan is turned ON at medium speed.");
        }
        
        // Overriding (Polymorphism)
        public override void TurnOff()
        {
            Console.WriteLine("Fan is turned OFF.");
        }
    }
}
