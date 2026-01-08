using System;

namespace Training.smart_home_automation
{
    //AC class inherits Appliance
    internal class AC : Appliance
    {
        public AC() : base("AC") { }
        
        // Overriding (Polymorphism)
        public override void TurnOn()
        {
            Console.WriteLine("AC is turned ON at 24°C cooling mode.");
        }
        
        // Overriding (Polymorphism)
        public override void TurnOff()
        {
            Console.WriteLine("AC is turned OFF.");
        }
    }
}
